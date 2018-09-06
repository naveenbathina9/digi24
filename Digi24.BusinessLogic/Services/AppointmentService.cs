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

        public ServiceResponse<bool> CreateAppointment(AppointmentEntity appointmentData)
        {
            ServiceResponse<bool> response = new ServiceResponse<bool>();
            try
            {
                int result = _appointmentRepository.Create(appointmentData);
                if(result > 0)
                {
                    response.ResponseData = result >0;
                    response.ResponseMessage = "Appointment created succesfully.";
                }else
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
    }
}
