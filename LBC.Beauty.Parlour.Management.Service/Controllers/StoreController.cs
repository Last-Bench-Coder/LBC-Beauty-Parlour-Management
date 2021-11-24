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
    [Route("api/store/")]
    public class StoreController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public StoreController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [EnableCors("CorsPolicy")]
        [Route("allstorerequest")]
        public IActionResult GetAllStores()
        {
            var allStores = _unitOfWork.Store.GetAllStore();
            return Ok(allStores);
        }

        [HttpGet]
        [EnableCors("CorsPolicy")]
        [Route("storerequestbyid")]
        public IActionResult GetStoreById(int catrequestId)
        {
            var Storeistrator = _unitOfWork.Store.GetStoreById(catrequestId);
            return Ok(Storeistrator);
        }

        [HttpPost]
        [EnableCors("CorsPolicy")]
        [Route("insertstorerequest")]
        public IActionResult InsertStore([FromBody] Store catrequest)
        {
            _unitOfWork.Store.InsertStore(catrequest);
            int i = _unitOfWork.Complete();
            return Ok("Success");
        }

        [HttpPost]
        [EnableCors("CorsPolicy")]
        [Route("bulkinsertstorerequest")]
        public IActionResult BulkInsertStore([FromBody] IEnumerable<Store> catrequest)
        {
            _unitOfWork.Store.BulkInsertStore(catrequest);
            int i = _unitOfWork.Complete();
            return Ok("Success");
        }

        [HttpPost]
        [EnableCors("CorsPolicy")]
        [Route("updatestorerequest")]
        public IActionResult UpdateStore([FromBody] Store catrequest)
        {
            _unitOfWork.Store.UpdateStore(catrequest);
            int i = _unitOfWork.Complete();
            return Ok("Success");
        }

        [HttpPost]
        [EnableCors("CorsPolicy")]
        [Route("bulkupdatestorerequest")]
        public IActionResult BulkUpdateStore([FromBody] IEnumerable<Store> catrequest)
        {
            _unitOfWork.Store.BulkUpdateStore(catrequest);
            int i = _unitOfWork.Complete();
            return Ok("Success");
        }

        [HttpPost]
        [EnableCors("CorsPolicy")]
        [Route("removestorerequest")]
        public IActionResult RemoveStore([FromBody] Store catrequest)
        {
            _unitOfWork.Store.RemoveStore(catrequest);
            int i = _unitOfWork.Complete();
            return Ok("Success");
        }

        [HttpPost]
        [EnableCors("CorsPolicy")]
        [Route("bulkremovestorerequest")]
        public IActionResult BulkRemoveStore([FromBody] IEnumerable<Store> catrequest)
        {
            _unitOfWork.Store.BulkRemoveStore(catrequest);
            int i = _unitOfWork.Complete();
            return Ok("Success");
        }
    }
}
