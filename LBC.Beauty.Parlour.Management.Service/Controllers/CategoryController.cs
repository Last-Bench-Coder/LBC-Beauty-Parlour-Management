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
    [Route("api/category/")]
    public class CategoryController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [EnableCors("CorsPolicy")]
        [Route("allcatrequest")]
        public IActionResult GetAllCategorys()
        {
            var allCategorys = _unitOfWork.Category.GetAllCategory();
            return Ok(allCategorys);
        }

        [HttpGet]
        [EnableCors("CorsPolicy")]
        [Route("catrequestbyid")]
        public IActionResult GetCategoryById(int catrequestId)
        {
            var Categoryistrator = _unitOfWork.Category.GetCategoryById(catrequestId);
            return Ok(Categoryistrator);
        }

        [HttpPost]
        [EnableCors("CorsPolicy")]
        [Route("insertcatrequest")]
        public IActionResult InsertCategory([FromBody] Category catrequest)
        {
            _unitOfWork.Category.InsertCategory(catrequest);
            int i = _unitOfWork.Complete();
            return Ok("Success");
        }

        [HttpPost]
        [EnableCors("CorsPolicy")]
        [Route("bulkinsertcatrequest")]
        public IActionResult BulkInsertCategory([FromBody] IEnumerable<Category> catrequest)
        {
            _unitOfWork.Category.BulkInsertCategory(catrequest);
            int i = _unitOfWork.Complete();
            return Ok("Success");
        }

        [HttpPost]
        [EnableCors("CorsPolicy")]
        [Route("updatecatrequest")]
        public IActionResult UpdateCategory([FromBody] Category catrequest)
        {
            _unitOfWork.Category.UpdateCategory(catrequest);
            int i = _unitOfWork.Complete();
            return Ok("Success");
        }

        [HttpPost]
        [EnableCors("CorsPolicy")]
        [Route("bulkupdatecatrequest")]
        public IActionResult BulkUpdateCategory([FromBody] IEnumerable<Category> catrequest)
        {
            _unitOfWork.Category.BulkUpdateCategory(catrequest);
            int i = _unitOfWork.Complete();
            return Ok("Success");
        }

        [HttpPost]
        [EnableCors("CorsPolicy")]
        [Route("removecatrequest")]
        public IActionResult RemoveCategory([FromBody] Category catrequest)
        {
            _unitOfWork.Category.RemoveCategory(catrequest);
            int i = _unitOfWork.Complete();
            return Ok("Success");
        }

        [HttpPost]
        [EnableCors("CorsPolicy")]
        [Route("bulkremovecatrequest")]
        public IActionResult BulkRemoveCategory([FromBody] IEnumerable<Category> catrequest)
        {
            _unitOfWork.Category.BulkRemoveCategory(catrequest);
            int i = _unitOfWork.Complete();
            return Ok("Success");
        }
    }
}
