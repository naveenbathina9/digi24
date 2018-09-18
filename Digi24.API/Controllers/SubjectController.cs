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
    [RoutePrefix("api/SubjectMaster")]
    public class SubjectController : ApiController
    {
        private readonly ISubjectService _subjectService;
        public SubjectController(ISubjectService subjectService)
        {
            _subjectService = subjectService;
        }



        [HttpPost]
        [Route("CreateSubject")]
        public HttpResponseMessage CreateSubject(string id1, string id2)
        {
            ServiceResponse<bool> response = null;
            try
            {
                if (ModelState.IsValid)
                {
                    response = _subjectService.CreateSubject(id1, id2);
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


        [HttpGet]
        [Route("GetSubjectById")]
        public HttpResponseMessage GetSubjectById(string id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var response = _subjectService.GetSubjectById(id);
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
        [Route("GetSubjectMaster")]
        public HttpResponseMessage GetSubjectMaster(string id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var response = _subjectService.GetSubjectMaster(id);
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
        [Route("GetSubjectMasterById")]
        public HttpResponseMessage GetSubjectMasterById(string id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var response = _subjectService.GetSubjectMasterById(id);
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


        [HttpPost]
        [Route("UpdateSubject")]
        public HttpResponseMessage UpdateSubject(SubjectEntity subjectData )
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var response = _subjectService.UpdateSubject(subjectData);
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
