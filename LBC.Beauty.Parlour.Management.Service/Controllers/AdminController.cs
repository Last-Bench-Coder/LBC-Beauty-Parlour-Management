using LBC.Beauty.Parlour.Management.Domain.Entities;
using LBC.Beauty.Parlour.Management.Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LBC.Beauty.Parlour.Management.Service.Controllers
{
    [ApiVersion("1.0")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    [Route("api/admin/")]
    public class AdminController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AdminController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [EnableCors("CorsPolicy")]
        [Route("alladmin")]
        public IActionResult GetAllAdministrators()
        {
            var allAdministrators = _unitOfWork.Administrators.GetAllAdministrators();
            return Ok(allAdministrators);
        }

        [HttpGet]
        [EnableCors("CorsPolicy")]
        [Route("adminbyid")]
        public IActionResult GetAdminById(int adminId)
        {
            var Administrator = _unitOfWork.Administrators.GetAdminById(adminId);
            return Ok(Administrator);
        }

        [HttpPost]
        [EnableCors("CorsPolicy")]
        [Route("insertadmin")]
        public IActionResult InsertAdmin([FromBody] Admin admin)
        {
            _unitOfWork.Administrators.InsertAdmin(admin);
            int i = _unitOfWork.Complete();
            return Ok("Success");
        }

        [HttpPost]
        [EnableCors("CorsPolicy")]
        [Route("bulkinsertadmin")]
        public IActionResult BulkInsertAdmin([FromBody] IEnumerable<Admin> admins)
        {
            _unitOfWork.Administrators.BulkInsertAdmin(admins);
            int i = _unitOfWork.Complete();
            return Ok("Success");
        }

        [HttpPost]
        [EnableCors("CorsPolicy")]
        [Route("updateadmin")]
        public IActionResult UpdateAdmin([FromBody] Admin admin)
        {
            _unitOfWork.Administrators.UpdateAdmin(admin);
            int i = _unitOfWork.Complete();
            return Ok("Success");
        }

        [HttpPost]
        [EnableCors("CorsPolicy")]
        [Route("bulkupdateadmin")]
        public IActionResult BulkUpdateAdmin([FromBody] IEnumerable<Admin> admins)
        {
            _unitOfWork.Administrators.BulkUpdateAdmin(admins);
            int i = _unitOfWork.Complete();
            return Ok("Success");
        }

        [HttpPost]
        [EnableCors("CorsPolicy")]
        [Route("removeadmin")]
        public IActionResult RemoveAdmin([FromBody] Admin admin)
        {
            _unitOfWork.Administrators.RemoveAdmin(admin);
            int i = _unitOfWork.Complete();
            return Ok("Success");
        }

        [HttpPost]
        [EnableCors("CorsPolicy")]
        [Route("bulkremoveadmin")]
        public IActionResult BulkRemoveAdmin([FromBody] IEnumerable<Admin> admins)
        {
            _unitOfWork.Administrators.BulkRemoveAdmin(admins);
            int i = _unitOfWork.Complete();
            return Ok("Success");
        }
    }
}
