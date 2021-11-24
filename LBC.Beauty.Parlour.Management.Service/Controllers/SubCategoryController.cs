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
    [Route("api/SubCategory/")]
    public class SubCategoryController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SubCategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [EnableCors("CorsPolicy")]
        [Route("allsubcatrequest")]
        public IActionResult GetAllSubCategorys()
        {
            var allSubCategorys = _unitOfWork.SubCategory.GetAllSubCategory();
            return Ok(allSubCategorys);
        }

        [HttpGet]
        [EnableCors("CorsPolicy")]
        [Route("subcatrequestbyid")]
        public IActionResult GetSubCategoryById(int catrequestId)
        {
            var SubCategoryistrator = _unitOfWork.SubCategory.GetSubCategoryById(catrequestId);
            return Ok(SubCategoryistrator);
        }

        [HttpPost]
        [EnableCors("CorsPolicy")]
        [Route("insertsubcatrequest")]
        public IActionResult InsertSubCategory([FromBody] SubCategory catrequest)
        {
            _unitOfWork.SubCategory.InsertSubCategory(catrequest);
            int i = _unitOfWork.Complete();
            return Ok("Success");
        }

        [HttpPost]
        [EnableCors("CorsPolicy")]
        [Route("bulkinsertsubcatrequest")]
        public IActionResult BulkInsertSubCategory([FromBody] IEnumerable<SubCategory> catrequest)
        {
            _unitOfWork.SubCategory.BulkInsertSubCategory(catrequest);
            int i = _unitOfWork.Complete();
            return Ok("Success");
        }

        [HttpPost]
        [EnableCors("CorsPolicy")]
        [Route("updatesubcatrequest")]
        public IActionResult UpdateSubCategory([FromBody] SubCategory catrequest)
        {
            _unitOfWork.SubCategory.UpdateSubCategory(catrequest);
            int i = _unitOfWork.Complete();
            return Ok("Success");
        }

        [HttpPost]
        [EnableCors("CorsPolicy")]
        [Route("bulkupdatesubcatrequest")]
        public IActionResult BulkUpdateSubCategory([FromBody] IEnumerable<SubCategory> catrequest)
        {
            _unitOfWork.SubCategory.BulkUpdateSubCategory(catrequest);
            int i = _unitOfWork.Complete();
            return Ok("Success");
        }

        [HttpPost]
        [EnableCors("CorsPolicy")]
        [Route("removesubcatrequest")]
        public IActionResult RemoveSubCategory([FromBody] SubCategory catrequest)
        {
            _unitOfWork.SubCategory.RemoveSubCategory(catrequest);
            int i = _unitOfWork.Complete();
            return Ok("Success");
        }

        [HttpPost]
        [EnableCors("CorsPolicy")]
        [Route("bulkremovesubcatrequest")]
        public IActionResult BulkRemoveSubCategory([FromBody] IEnumerable<SubCategory> catrequest)
        {
            _unitOfWork.SubCategory.BulkRemoveSubCategory(catrequest);
            int i = _unitOfWork.Complete();
            return Ok("Success");
        }
    }
}
