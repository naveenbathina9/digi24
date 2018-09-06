using Digi24.BusinessLogic.Contracts;
using System;
using Digi24.Entities;
using Digi24.Repository.Contracts;

namespace Digi24.BusinessLogic.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public ServiceResponse<bool> CreateStudent(StudentEntity studentData)
        {
            ServiceResponse<bool> response = new ServiceResponse<bool>();
            try
            {
                var result = _studentRepository.Create(studentData) > 0;
                response.ResponseData = result;
                if (result)
                    response.ResponseMessage = "New Student has been created.";
                else
                    response.ResponseMessage = "Error while creating student, Please try again.";
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
