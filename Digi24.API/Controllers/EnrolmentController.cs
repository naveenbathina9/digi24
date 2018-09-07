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
    public class EnrolmentController : ApiController
    {
        private readonly IEnrolmentService _enrolmentService;
        public EnrolmentController(IEnrolmentService enrolmentService)
        {
            _enrolmentService = enrolmentService;
        }


        [HttpPost]
        [Route("CreateEnrolment")]
        public HttpResponseMessage CreateEnrolment(EnrolmentEntity enrolmentEntity)
        {
            try
            {
                var response = _enrolmentService.CreateEnrolment(enrolmentEntity);
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        [HttpPost]
        [Route("UpdateEnrolment")]
        public HttpResponseMessage UpdateEnrolment(EnrolmentEntity enrolmentEntity)
        {
            try
            {
                var response = _enrolmentService.UpdateEnrolment(enrolmentEntity);
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
