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
    [Authorize]
    [ApiVersion("1.0")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    [Route("api/secquest/")]
    public class SecurityQuestionController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SecurityQuestionController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [EnableCors("CorsPolicy")]
        [Route("allsecquest")]
        public IActionResult GetAllSecurityQuestions()
        {
            var allSecurityQuestions = _unitOfWork.SecurityQuestion.GetAllSecurityQuestion();
            return Ok(allSecurityQuestions);
        }

        [HttpGet]
        [EnableCors("CorsPolicy")]
        [Route("secquestbyid")]
        public IActionResult GetSecurityQuestionById(int secquestId)
        {
            var SecurityQuestionistrator = _unitOfWork.SecurityQuestion.GetSecurityQuestionById(secquestId);
            return Ok(SecurityQuestionistrator);
        }

        [HttpPost]
        [EnableCors("CorsPolicy")]
        [Route("insertsecquest")]
        public IActionResult InsertSecurityQuestion([FromBody] SecurityQuestion secquest)
        {
            _unitOfWork.SecurityQuestion.InsertSecurityQuestion(secquest);
            int i = _unitOfWork.Complete();
            return Ok("Success");
        }

        [HttpPost]
        [EnableCors("CorsPolicy")]
        [Route("bulkinsertsecquest")]
        public IActionResult BulkInsertSecurityQuestion([FromBody] IEnumerable<SecurityQuestion> secquests)
        {
            _unitOfWork.SecurityQuestion.BulkInsertSecurityQuestion(secquests);
            int i = _unitOfWork.Complete();
            return Ok("Success");
        }

        [HttpPost]
        [EnableCors("CorsPolicy")]
        [Route("updatesecquest")]
        public IActionResult UpdateSecurityQuestion([FromBody] SecurityQuestion secquest)
        {
            _unitOfWork.SecurityQuestion.UpdateSecurityQuestion(secquest);
            int i = _unitOfWork.Complete();
            return Ok("Success");
        }

        [HttpPost]
        [EnableCors("CorsPolicy")]
        [Route("bulkupdatesecquest")]
        public IActionResult BulkUpdateSecurityQuestion([FromBody] IEnumerable<SecurityQuestion> secquests)
        {
            _unitOfWork.SecurityQuestion.BulkUpdateSecurityQuestion(secquests);
            int i = _unitOfWork.Complete();
            return Ok("Success");
        }

        [HttpPost]
        [EnableCors("CorsPolicy")]
        [Route("removesecquest")]
        public IActionResult RemoveSecurityQuestion([FromBody] SecurityQuestion secquest)
        {
            _unitOfWork.SecurityQuestion.RemoveSecurityQuestion(secquest);
            int i = _unitOfWork.Complete();
            return Ok("Success");
        }

        [HttpPost]
        [EnableCors("CorsPolicy")]
        [Route("bulkremovesecquest")]
        public IActionResult BulkRemoveSecurityQuestion([FromBody] IEnumerable<SecurityQuestion> secquests)
        {
            _unitOfWork.SecurityQuestion.BulkRemoveSecurityQuestion(secquests);
            int i = _unitOfWork.Complete();
            return Ok("Success");
        }
    }
}
