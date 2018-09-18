using Digi24.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digi24.BusinessLogic.Contracts
{
    public interface IExaminationService
    {
        ServiceResponse<bool> CreateExamination(ExaminationEntity examinationEntity);
        ServiceResponse<ExaminationEntity> GetExaminationByExType(int id);
        ServiceResponse<ExaminationEntity> GetExaminationByAcdYear(int id);
        //ServiceResponse<bool> AcceptAppointment(int id);
        //ServiceResponse<bool> RejectAppointment(int id);
        ServiceResponse<bool> UpdateExamination(ExaminationEntity id);

    }
}
