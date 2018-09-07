using Digi24.BusinessLogic.Contracts;
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



    }
}
