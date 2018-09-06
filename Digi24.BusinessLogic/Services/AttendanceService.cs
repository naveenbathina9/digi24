using Digi24.BusinessLogic.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Digi24.ViewModels;
using Digi24.Repository.Contracts;
using Digi24.Entities;

namespace Digi24.BusinessLogic.Services
{
    public class AttendanceService : IAttendanceService
    {
        private readonly IAttendanceRepository _attendanceRepository;
        public AttendanceService(IAttendanceRepository attendanceRepository)
        {
            _attendanceRepository = attendanceRepository;
        }

        public ServiceResponse<bool> CreateAttendance(CreateAttendanceViewModel attendanceData)
        {
            ServiceResponse<bool> response = new ServiceResponse<bool>();
            try
            {
                AttendanceEntity entity = new AttendanceEntity()
                {
                    //AttendanceId = attendanceData.AttendanceId,
                    AttendanceMode = attendanceData.AttendanceMode,
                    CapturedDate = attendanceData.CapturedDate,
                    Period = attendanceData.Period,
                    StandardId = attendanceData.StandardId,
                    TeacherId = attendanceData.TeacherId
                };
                bool addComma = false;
                StringBuilder absentList = new StringBuilder();
                foreach (var studentId in attendanceData.AbsentStudentsList)
                {
                    if (addComma)
                    {
                        absentList.Append("," + studentId);
                    }
                    else
                    {
                        absentList.Append(studentId);
                        addComma = false;
                    }
                }
                entity.AbsentStudentList = absentList.ToString();
                response.ResponseData = _attendanceRepository.Create(entity) > 0;
            }
            catch (Exception)
            {
                response.IsFaulted = true;
                response.ResponseMessage = "Unable to process your request, Please try again";
            }

            return response;
        }

        public ServiceResponse<AttendanceViewModel> GetAttendanceDetails(int id)
        {
            throw new NotImplementedException();
        }

        public ServiceResponse<StudentAttendanceViewModel> GetStudentAttendance(string studentId, DateTime date)
        {
            throw new NotImplementedException();
        }

        public ServiceResponse<bool> UpdateAttendance(CreateAttendanceViewModel attendanceData)
        {
            throw new NotImplementedException();
        }
    }
}
