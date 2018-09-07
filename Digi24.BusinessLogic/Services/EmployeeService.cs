using Digi24.BusinessLogic.Contracts;
using Digi24.Entities;
using Digi24.Repository.Contracts;
using Digi24.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digi24.BusinessLogic.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public ServiceResponse<bool> CreateEmployee(EmployeeEntity employeeEntity)
        {
            ServiceResponse<bool> response = new ServiceResponse<bool>();
            try
            {
                var result = _employeeRepository.Create(employeeEntity) > 0;
                response.ResponseData = result;
                if (result)
                    response.ResponseMessage = "New Employee has been created.";
                else
                    response.ResponseMessage = "Error while creating Employee, Please try again.";
            }
            catch (Exception)
            {
                response.IsFaulted = true;
                response.ResponseMessage = "Internal server errror, Please try again.";
            }

            return response;
        }

        public ServiceResponse<EmployeeViewModel> GetEmployeeById(String EmployeeId)
        {
            var entity = _employeeRepository.GetById(EmployeeId);
            ServiceResponse<EmployeeViewModel> serviceResponse = new ServiceResponse<EmployeeViewModel>();

            EmployeeViewModel details = new EmployeeViewModel()
            {
                EmployeeId = entity.EmployeeId,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Designation = entity.Designation,
                UserName = entity.UserName

            };
            serviceResponse.ResponseData = details;
            serviceResponse.ResponseMessage = "Retrieved employee details.";
            return serviceResponse;

        }

        public ServiceResponse<bool> UpdateEmployee(EmployeeEntity employeeEntity)
        {
            ServiceResponse<bool> response = new ServiceResponse<bool>();
            try
            {
                var result = _employeeRepository.Update(employeeEntity);
                response.ResponseData = result;
                if (result)
                    response.ResponseMessage = "Employee data has been Updated.";
                else
                    response.ResponseMessage = "Error while Updating Employee, Please try again.";
            }
            catch (Exception)
            {
                response.IsFaulted = true;
                response.ResponseMessage = "Internal server errror, Please try again.";
            }

            return response;
        }
    }
}
