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
    public  class ManagerService
    {
        private string connectionString = "Server=localhost;port=5432;Database=Exams;User Id=postgres;password=0711;";



        public NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
        }

        public async Task <List<DepartmentManager>> GetDepartmentManager()
        {
            using (var connection = GetConnection())
            {
                var sql = "select E.Id as ManagerId,concat(E.FirsName,'',E.LastName) as ManagerFullName," +
                        " D.Id as DepartmentId,D.Name as DepartmentName ,DM.FromDate,DM.ToDate "+
                        " from Department_Manager as DM "+
                        " join Employee as E on E.Id = DM.EmployeeId " +
                        " join Department as D on D.Id = DM.DepartmentId ";

                var result = await connection.QueryAsync<DepartmentManager>(sql);
                return result.ToList();
            }
        }

        public async Task <int> ManagerInsert(DepartmentDM manager)
        {
            using (var con =GetConnection())
            {
                var sql = $" Insert into DepartmentManager(EmployeeId,DepartmentId,FromDate,ToDate)" +
                    $" Values( {manager.EmployeeId}," +
                    $" {manager.DepartmentId}," +
                    $" '{manager.FromDate}'," +
                    $" '{manager.ToDate}' ) ";
                var insert = await con.ExecuteAsync(sql);
                return  insert;
                      
             }
        }

       

    }
}
