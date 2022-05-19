using Domain;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentController : ControllerBase
    {
        private DepartmentService departmentService;

        public DepartmentController(DepartmentService departmentService)
        {
            this.departmentService = departmentService;
        }


        [HttpGet("GetDepartment")]
        public async Task<List<DepartmentD>> GetDepartment()
        {
            return await departmentService.GetDepartment();

        }

        [HttpPost("Insert")]
        public async Task<int> Insert(Department department)
        {
            return await departmentService.Insert(department);
        }
      
        [HttpPut("Update")]
        public async Task <int> Update(Department department, int Id)
        {
            return await departmentService.Update(department, Id);
        }

    }
}
