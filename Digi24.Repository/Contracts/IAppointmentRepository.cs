using Digi24.Entities;
using Digi24.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digi24.Repository.Contracts
{
    using Entities;
    using Infrastructure;

    public interface IAppointmentRepository : IRepository<AppointmentEntity>
    {
        int AcceptAppointment(int appointmentId);
    }
}
