﻿using Digi24.BusinessLogic.Contracts;
using Digi24.Entities;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Digi24.API.Controllers
{
    [RoutePrefix("api/Student")]
    public class StudentController : ApiController
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpPost]
        [Route("CreateStudent")]
        public HttpResponseMessage CreateStudent(StudentEntity studentData)
        {
            try
            {
                var response = _studentService.CreateStudent(studentData);
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        [HttpGet]
        [Route("StudentId")]
        public HttpResponseMessage GetStudentByID(int id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var response = _studentService.GetStudentById(id);
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
        [Route("GetStudentByStandard")]
        public HttpResponseMessage GetStudentByStandardID(string id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var response = _studentService.GetStudentByStandardId(id);
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
        [Route("UpdateAttendance")]
        public HttpResponseMessage UpdateAppointment(StudentEntity studentData)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var response = _studentService.UpdateStudent(studentData);
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
