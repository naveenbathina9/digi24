using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digi24.ViewModels
{
    public class AttendanceViewModel
    {
        public int AttendanceId { get; set; }
        public DateTime CapturedDate { get; set; }
        public string AttendanceMode { get; set; }
        public string Period { get; set; }
        public string TeacherId { get; set; }
        public string StandardId { get; set; }
        public List<string> AbsentStudentsList { get; set; }
    }

    public class AbsentHistory
    {
        public DateTime AbsentDate { get; set; }
        public string Period { get; set; }
    }

    public class StudentAttendanceViewModel
    {
        public string StudentId { get; set; }
        public List<AbsentHistory> AbsentDays { get; set; }
    }

    public class CreateAttendanceViewModel
    {
        public int AttendanceId { get; set; }
        public DateTime CapturedDate { get; set; }
        public string AttendanceMode { get; set; }
        public string Period { get; set; }
        public string TeacherId { get; set; }
        public string StandardId { get; set; }
        public List<string> AbsentStudentsList { get; set; }
    }
}
