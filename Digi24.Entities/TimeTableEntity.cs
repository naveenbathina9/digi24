using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digi24.Entities
{
    public class TimeTableEntity
    {
        public int TimeTableId { get; set; }
        public string StandardId { get; set; }
        public string SubjectId { get; set; }
        public int PeriodNumber { get; set; }
        public int WeekDay { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
