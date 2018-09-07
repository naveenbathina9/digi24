using Digi24.Entities;
using Digi24.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digi24.BusinessLogic.Contracts
{
    public interface IMarksService
    {
        ServiceResponse<bool> CreateMarks(MarksEntity marksEntity);
        ServiceResponse<bool> UpdateMarks(MarksEntity marksEntity);
        ServiceResponse<MarksViewModel> GetMarksByStudentId(String EmployeeId);
    }
}
