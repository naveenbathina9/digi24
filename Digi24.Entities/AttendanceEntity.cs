using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digi24.Entities
{
    public class AttendanceEntity
    {
        //public int AttendanceId { get; set; }
        public DateTime CapturedDate { get; set; }
        public string AttendanceMode { get; set; }
        public string Period { get; set; }
        public string TeacherId { get; set; }
        public string StandardId { get; set; }
        public string AbsentStudentList { get; set; }
        //public List<AbsentHistoryEntity> AbsentStudents { get; set; }
    }

    public class AbsentHistoryEntity
    {
        public int AttendanceId { get; set; }
        public string StudentId { get; set; }
    }
}
