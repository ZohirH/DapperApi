using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Domain;

namespace Service
{
    public class DepartmentService
    {
        private string connectionString = "Server=localhost;port=5432;Database=Exam;User Id=postgres;password=MyData;";

      
        
        public NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
        }
        public async Task<List<DepartmentD>> GetDepartment()
        {
            using (var connection = GetConnection())
            {
                var sql =" select D.Id, D.Name,E.Id as ManagerId, concat(E.FirsName,'  ', E.LastName) as ManagerFullName "+
                "  from Department as D "+
                 " join Employee as E on D.Id = E.Id  ";
    
                var result = await connection.QueryAsync<DepartmentD>(sql);
                return result.ToList();
            }
        }
        public async Task <int> Insert(Department department)
        {
            using (var con=GetConnection())
            {
                var sql = $" Insert into Department(Name) " +
                          $" values('{department.Name}') ";
                
             var insert = await  con.ExecuteAsync(sql);
                return insert;
            }
        }
        public async Task <int> Update(Department department ,int Id)
        {
            using (var con = GetConnection())
            {
                var sql = $" Update Department set Name='{department.Name}' Where Id={Id} ";
                var update = await  con.ExecuteAsync(sql);
                return update;
            }
        }
    }
}
