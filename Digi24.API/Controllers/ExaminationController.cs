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
    [RoutePrefix("api/Examination")]
    public class ExaminationController : ApiController
    {
        private readonly IExaminationService _examinationService;
        public ExaminationController(IExaminationService examinationService)
        {
            _examinationService = examinationService;
        }
        // GET: Examination


        [HttpPost]
        [Route("CreateExamination")]
        public HttpResponseMessage CreateExamination(ExaminationEntity examinationEntity)
        {

            ServiceResponse<bool> response = null;
            try
            {
                if (ModelState.IsValid)
                {
                    response = _examinationService.CreateExamination(examinationEntity);
                    return Request.CreateResponse(HttpStatusCode.OK, response);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
                }
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Problem in server, Please try again.");
            }

        }

        [HttpPost]
        [Route("UpdateExamination")]
        public HttpResponseMessage UpdateExamination(ExaminationEntity examinationEntity)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var response = _examinationService.UpdateExamination(examinationEntity);
                    return Request.CreateResponse(HttpStatusCode.OK, response);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
                }
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("GetExaminationByExamType")]
        public HttpResponseMessage GetExaminationByExamType(int id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var response = _examinationService.GetExaminationByExType(id);
                    return Request.CreateResponse(HttpStatusCode.OK, response);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
                }

            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("GetExaminationByAcademicYear")]
        public HttpResponseMessage GetExaminationByAcademicYear(int id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var response = _examinationService.GetExaminationByAcdYear(id);
                    return Request.CreateResponse(HttpStatusCode.OK, response);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
                }

            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


    }
}
