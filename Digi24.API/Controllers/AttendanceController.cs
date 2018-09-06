using Digi24.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Digi24.API.Controllers
{
    [EnableCors("*", "*", "*", "*")]
    public class AttendanceController : ApiController
    {
        public AttendanceController()
        {

        }


        [HttpPost]
        [Route("CreateAttendance")]
        public HttpResponseMessage CreateAttendance(CreateAttendanceViewModel attendanceData)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Request procesed succesfully");
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
        [Route("UpdateAttendance")]
        public HttpResponseMessage UpdateAttendance(CreateAttendanceViewModel attendanceData)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Request procesed succesfully");
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
        [Route("GetAttendanceDetails/{id}")]
        public HttpResponseMessage GetAttendanceDetails(int id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Request procesed succesfully");
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
        [Route("GetStudentAttendance/{studentId}/{date}")]
        public HttpResponseMessage GetAttendanceDetails(string studentId, DateTime date)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Request procesed succesfully");
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
