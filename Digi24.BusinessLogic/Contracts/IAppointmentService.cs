using Digi24.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digi24.BusinessLogic.Contracts
{
    public interface IAppointmentService
    {
        ServiceResponse<bool> CreateAppointment(AppointmentEntity appointmentData);
        ServiceResponse<AppointmentEntity> GetAppointmentById(int id);
        ServiceResponse<bool> AcceptAppointment(int id);
        ServiceResponse<bool> RejectAppointment(int id);
        ServiceResponse<bool> UpdateAppointment(AppointmentEntity id);
    }
}
