using Domain;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
       private  EmployeeService employeeService;

        public EmployeeController(EmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

    [HttpGet("GetEmployee")]
        public async Task <List<EmployeeE>> GetDepartment()
        {
            return await employeeService.GetEmployee();

        }

    [HttpPost("Insert")]
        public async Task <int> Insert(Employee employee)
        {
            //jkjkjkjk
            return await employeeService.Insert(employee);
        }


    [HttpPut("Update")]
        public async Task <int> Update(Employee employee, int Id)
        {
            return await employeeService.Update(employee, Id);
        }

    }
}
