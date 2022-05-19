using Domain;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ManagerController : ControllerBase
    {
        private ManagerService managerService;

        public ManagerController(ManagerService managerService)
        {
            this.managerService = managerService;
        }

        [HttpGet("GetDepartmentManager")]
        public async Task<List<DepartmentManager>> GetDepartmentManager()
        {
            return await managerService.GetDepartmentManager();
        }

        [HttpPost("ManagerInsert")]
        public async Task <int> ManagerInsert(DepartmentDM manager)
        {
            return await managerService.ManagerInsert(manager);
        }
    }
}
