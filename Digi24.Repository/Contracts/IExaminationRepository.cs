using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digi24.Repository.Contracts
{
    using Entities;
    using Infrastructure;
    public interface IExaminationRepository : IRepository<ExaminationEntity>
    {
        ExaminationEntity GetExamByExamType(int ExamimationId);
        ExaminationEntity GetExamByAcademicYear(int ExamimationId);
    }
}
