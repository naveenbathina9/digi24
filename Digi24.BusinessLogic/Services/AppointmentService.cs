using Digi24.BusinessLogic.Contracts;
using Digi24.Entities;
using Digi24.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digi24.BusinessLogic.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentRepository _appointmentRepository;
        public AppointmentService(IAppointmentRepository appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }

        public ServiceResponse<bool> AcceptAppointment(int id)
        {
            ServiceResponse<bool> response = new ServiceResponse<bool>();
            try
            {
                int result = _appointmentRepository.AcceptAppointment(id);
                if (result > 0)
                {
                    response.ResponseData = result > 0;
                    response.ResponseMessage = "Appointment accepted succesfully.";
                }
                else
                {
                    response.ResponseData = result > 0;
                    response.ResponseMessage = "No changes were made, Please try again.";
                }
            }
            catch (Exception)
            {
                response.IsFaulted = true;
                response.ResponseMessage = "No changes were made, Internal error.";
            }
            return response;
        }

        public ServiceResponse<bool> CreateAppointment(AppointmentEntity appointmentData)
        {
            ServiceResponse<bool> response = new ServiceResponse<bool>();
            try
            {
                int result = _appointmentRepository.Create(appointmentData);
                if (result > 0)
                {
                    response.ResponseData = result > 0;
                    response.ResponseMessage = "Appointment created succesfully.";
                }
                else
                {
                    response.ResponseData = result > 0;
                    response.ResponseMessage = "Appointment is not created, Please try again.";
                }
            }
            catch (Exception)
            {
                response.IsFaulted = true;
                response.ResponseMessage = "Appointment is not created, Internal error.";
            }
            return response;
        }

        public ServiceResponse<AppointmentEntity> GetAppointmentById(int id)
        {
            ServiceResponse<AppointmentEntity> response = new ServiceResponse<AppointmentEntity>();
            try
            {
                response.ResponseData = _appointmentRepository.GetById(id);
                if (response.ResponseData != null)
                    response.ResponseMessage = "Get Appontment By Id.";
                else
                    response.ResponseMessage = "Unable to get Appointment ById.";
            }
            catch (Exception)
            {
                response.IsFaulted = true;
                response.ResponseMessage = "Internal server error, Please try again.";
                throw;
            }
            return response;
            //var entity = _appointmentRepository.GetById(id);
            //return entity;
        }

        public ServiceResponse<bool> RejectAppointment(int id)
        {

            ServiceResponse<bool> response = new ServiceResponse<bool>();
            try
            {
                int result = _appointmentRepository.RejectAppointment(id);
                if (result > 0)
                {
                    response.ResponseData = result > 0;
                    response.ResponseMessage = "Appointment Rejected succesfully.";
                }
                else
                {
                    response.ResponseData = result > 0;
                    response.ResponseMessage = "No changes were made, Please try again.";
                }
            }
            catch (Exception)
            {
                response.IsFaulted = true;
                response.ResponseMessage = "No changes were made, Internal error.";
            }
            return response;
        }

        public ServiceResponse<bool> UpdateAppointment(AppointmentEntity id)
        {
            ServiceResponse<bool> response = new ServiceResponse<bool>();
            try
            {
                var result = _appointmentRepository.Update(id);
                response.ResponseData = result;
                if (result)
                    response.ResponseMessage = "Appointment data has been Updated.";
                else
                    response.ResponseMessage = "Error while Updating Appointment, Please try again.";
            }
            catch (Exception)
            {
                response.IsFaulted = true;
                response.ResponseMessage = "Internal server errror, Please try again.";
            }

            return response;
        }
    }
}
