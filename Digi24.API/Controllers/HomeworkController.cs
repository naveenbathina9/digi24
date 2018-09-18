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
    [RoutePrefix("api/Homework")]
    public class HomeworkController : ApiController
    {

        private readonly IHomeworkService _homeworkService;
        public HomeworkController(IHomeworkService homeworkService)
        {
            _homeworkService = homeworkService;
        }


        public HomeworkController()
        {

        }


        [HttpPost]
        [Route("CreatehomeWork")]
        public HttpResponseMessage CreateHomework(HomeWorkEntity homeWorkData)
        {
            ServiceResponse<bool> response = null;
            try
            {
                if (ModelState.IsValid)
                {
                    response = _homeworkService.CreateHomework(homeWorkData);
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
        [Route("GetHomework")]
        public HttpResponseMessage GetHomeworkByID(string SubjId, string standId, DateTime date)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var response = _homeworkService.GetHomeWorkById(SubjId, standId,date);
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
        [Route("UpdateHomework")]
        public HttpResponseMessage UpdateHomework(HomeWorkEntity homeWorkData)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var response = _homeworkService.UpdateHomeWork(homeWorkData);
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
