using Digi24.BusinessLogic.Contracts;
using Digi24.ViewModels;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Digi24.API.Controllers
{
    [RoutePrefix("api/masterdata")]
    public class MasterDataController : ApiController
    {
        private readonly IExamTypeService _examTypeService;
        private readonly ISubjectService _subjectService;
        public MasterDataController(IExamTypeService examTypeService, ISubjectService subjectService)
        {
            _examTypeService = examTypeService;
            _subjectService = subjectService;
        }

        [HttpPost]
        [Route("CreateExamType")]
        public HttpResponseMessage CreateExamType(CreateExamTypeViewModel examTypeData)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                var response =  _examTypeService.CreateExamType(examTypeData.Title, examTypeData.Description);

                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("GetAllExamTypes")]
        public HttpResponseMessage GetAllExamTypes()
        {
            try
            {
                var response = _examTypeService.GetAllExamTypes();
                if(response == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Umable to process your request.");
                }
                
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("GetAllSubjects")]
        public HttpResponseMessage GetAllSubjects()
        {
            try
            {
                var response = _subjectService.GetAllSubjects();
                if (response == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Umable to process your request.");
                }

                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("CreateSubject")]
        public HttpResponseMessage CreateSubject(CreateSubjectViewModel subjectData)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                var response = _examTypeService.CreateExamType(subjectData.Title, subjectData.StandardId);

                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

    }
}
