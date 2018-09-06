using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digi24.Entities
{
    public class AppointmentEntity
    {
        public int AppointmentId { get; set; }
        public DateTime RequestedDate { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Subject { get; set; }
        public string Reason { get; set; }
        public string WhomToMeet { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
    }
}
