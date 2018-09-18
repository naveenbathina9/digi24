﻿using Digi24.BusinessLogic.Contracts;
using Digi24.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Digi24.API.Controllers
{
    [RoutePrefix("api/Appointment")]
    public class AppointmentController : ApiController
    {
        private readonly IAppointmentService _appointmentService;
        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }




        [HttpPost]
        [Route("CreateAppointment")]
        public HttpResponseMessage CreateAppointment(AppointmentEntity appointmentData)
        {
            ServiceResponse<bool> response = null;
            try
            {
                if (ModelState.IsValid)
                {
                    response = _appointmentService.CreateAppointment(appointmentData);
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
        [Route("AcceptAppointment")]
        public HttpResponseMessage AcceptAppointment(int id)
        {
            try
            {
                var response = _appointmentService.AcceptAppointment(id);
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("RejectAppointment")]
        public HttpResponseMessage RejectAppointment(int id)
        {
            try
            {
                var response = _appointmentService.RejectAppointment(id);
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }



        [HttpGet]
        [Route("GetAppointment")]
        public HttpResponseMessage GetAppointmentById(int id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var response = _appointmentService.GetAppointmentById(id);
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
        public HttpResponseMessage UpdateAppointment(AppointmentEntity appointmentEntity)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var response = _appointmentService.UpdateAppointment(appointmentEntity);
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
