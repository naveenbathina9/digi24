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
    [RoutePrefix("api/Employee")]

    public class EmployeeController : ApiController
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpPost]
        [Route("CreateEmployee")]
        public HttpResponseMessage CreateEmployee(EmployeeEntity employeeEntity)
        {
            try
            {
                var response = _employeeService.CreateEmployee(employeeEntity);
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("GetEmployeeById")]
        public HttpResponseMessage GetEmployeeById(String id)
        {
            try
            {
                var response = _employeeService.GetEmployeeById(id);
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        [HttpPost]
        [Route("UpdateEmployee")]
        public HttpResponseMessage UpdateEmployee(EmployeeEntity employeeEntity)
        {
            try
            {
                var response = _employeeService.UpdateEmployee(employeeEntity);
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
