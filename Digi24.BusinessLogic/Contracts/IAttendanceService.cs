using Digi24.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digi24.BusinessLogic.Contracts
{
    public interface IAttendanceService
    {
        ServiceResponse<bool> CreateAttendance(CreateAttendanceViewModel attendanceData);
        ServiceResponse<bool> UpdateAttendance(CreateAttendanceViewModel attendanceData);
        ServiceResponse<AttendanceViewModel> GetAttendanceDetails(int id);
        ServiceResponse<StudentAttendanceViewModel> GetStudentAttendance(string studentId, DateTime date);
    }
}
