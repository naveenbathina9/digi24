using Digi24.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digi24.BusinessLogic.Contracts
{
    public interface IExamTypeService
    {
        ServiceResponse<bool> CreateExamType(string title, string description);
        ServiceResponse<List<ExamType>> GetAllExamTypes();
    }
}
