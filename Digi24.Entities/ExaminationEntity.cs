using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digi24.Entities
{
    public class ExaminationEntity
    {
        public int ExamimationId { get; set; }
        public string Title { get; set; }
        public string AcademicYear { get; set; }
        public int ExamTypeId { get; set; }
    }
}
