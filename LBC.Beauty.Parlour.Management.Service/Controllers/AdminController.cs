using LBC.Beauty.Parlour.Management.Domain.Entities;
using LBC.Beauty.Parlour.Management.Domain.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LBC.Beauty.Parlour.Management.Service.Controllers
{
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class AdminController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AdminController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [EnableCors("CorsPolicy")]
        [Route("api/admin/alladmin")]
        public IActionResult GetAllAdministrators()
        {
            var allAdministrators = _unitOfWork.Administrators.GetAllAdministrators();
            return Ok(allAdministrators);
        }

        [HttpGet]
        [EnableCors("CorsPolicy")]
        [Route("api/admin/adminbyid")]
        public IActionResult GetAdminById(int adminId)
        {
            var Administrator = _unitOfWork.Administrators.GetAdminById(adminId);
            return Ok(Administrator);
        }

        [HttpPost]
        [EnableCors("CorsPolicy")]
        [Route("api/admin/insertadmin")]
        public IActionResult InsertAdmin([FromBody] Admin admin)
        {
            _unitOfWork.Administrators.InsertAdmin(admin);
            int i = _unitOfWork.Complete();
            return Ok("Success");
        }

        [HttpPost]
        [EnableCors("CorsPolicy")]
        [Route("api/admin/bulkinsertadmin")]
        public IActionResult BulkInsertAdmin([FromBody] IEnumerable<Admin> admins)
        {
            _unitOfWork.Administrators.BulkInsertAdmin(admins);
            int i = _unitOfWork.Complete();
            return Ok("Success");
        }

        [HttpPost]
        [EnableCors("CorsPolicy")]
        [Route("api/admin/updateadmin")]
        public IActionResult UpdateAdmin([FromBody] Admin admin)
        {
            _unitOfWork.Administrators.UpdateAdmin(admin);
            int i = _unitOfWork.Complete();
            return Ok("Success");
        }

        [HttpPost]
        [EnableCors("CorsPolicy")]
        [Route("api/admin/bulkupdateadmin")]
        public IActionResult BulkUpdateAdmin([FromBody] IEnumerable<Admin> admins)
        {
            _unitOfWork.Administrators.BulkUpdateAdmin(admins);
            int i = _unitOfWork.Complete();
            return Ok("Success");
        }

        [HttpPost]
        [EnableCors("CorsPolicy")]
        [Route("api/admin/removeadmin")]
        public IActionResult RemoveAdmin([FromBody] Admin admin)
        {
            _unitOfWork.Administrators.RemoveAdmin(admin);
            int i = _unitOfWork.Complete();
            return Ok("Success");
        }

        [HttpPost]
        [EnableCors("CorsPolicy")]
        [Route("api/admin/bulkremoveadmin")]
        public IActionResult BulkRemoveAdmin([FromBody] IEnumerable<Admin> admins)
        {
            _unitOfWork.Administrators.BulkRemoveAdmin(admins);
            int i = _unitOfWork.Complete();
            return Ok("Success");
        }
    }
}
