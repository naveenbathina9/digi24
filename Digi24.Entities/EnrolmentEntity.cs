using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digi24.Entities
{
    public class EnrolmentEntity
    {
        public int EnrolmentId { get; set; }
        public string StudentId { get; set; }
        public string StandardId { get; set; }
        public string AcademicYear { get; set; }
        public bool IsPromoted { get; set; }
    }
}
