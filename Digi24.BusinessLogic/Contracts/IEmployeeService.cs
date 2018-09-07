using Digi24.Entities;
using Digi24.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digi24.BusinessLogic.Contracts
{
    public interface IEmployeeService
    {
        ServiceResponse<bool> CreateEmployee(EmployeeEntity employeeEntity);
        ServiceResponse<bool> UpdateEmployee(EmployeeEntity employeeEntity);
        ServiceResponse<EmployeeViewModel> GetEmployeeById(String EmployeeId);
    }
}
