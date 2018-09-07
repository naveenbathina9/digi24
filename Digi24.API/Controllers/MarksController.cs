using Digi24.BusinessLogic.Contracts;
using Digi24.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Digi24.API.Controllers
{
    public class MarksController : ApiController
    {
        private readonly IMarksService _marksService;
        public MarksController(IMarksService marksService)
        {
            _marksService = marksService;
        }

        [HttpPost]
        [Route("CreateMarks")]
        public HttpResponseMessage CreateMarks(MarksEntity marksEntity)
        {
            try
            {
                var response = _marksService.CreateMarks(marksEntity);
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("GetMarksByEmployeeId")]
        public HttpResponseMessage GetMarksByEmployeeId(String id)
        {
            try
            {
                var response = _marksService.GetMarksByStudentId(id);
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("UpdateMarks")]
        public HttpResponseMessage UpdateMarks(MarksEntity marksEntity)
        {
            try
            {
                var response = _marksService.UpdateMarks(marksEntity);
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

    }
}
