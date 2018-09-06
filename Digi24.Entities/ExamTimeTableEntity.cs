using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digi24.Entities
{
    public class ExamTimeTableEntity
    {
        public int Id { get; set; }
        public int ExaminationId { get; set; }
        public DateTime ExamDate { get; set; }
        public string StandardId { get; set; }
        public string SubjectId { get; set; }
    }
}
