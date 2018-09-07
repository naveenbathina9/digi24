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
    public class EnrolmentService : IEnrolmentService
    {
        private readonly IEnrolmentRepository _enrolmentRepository;
        public EnrolmentService(IEnrolmentRepository enrolmentRepository)
        {
            _enrolmentRepository = enrolmentRepository;
        }


        public ServiceResponse<bool> CreateEnrolment(EnrolmentEntity enrolmentEntity)
        {
            ServiceResponse<bool> response = new ServiceResponse<bool>();
            try
            {
                var result = _enrolmentRepository.Create(enrolmentEntity) > 0;
                response.ResponseData = result;
                if (result)
                    response.ResponseMessage = "New Enrolment has been created.";
                else
                    response.ResponseMessage = "Error while creating Enrolment, Please try again.";
            }
            catch (Exception)
            {
                response.IsFaulted = true;
                response.ResponseMessage = "Internal server errror, Please try again.";
            }

            return response;
        }

        public ServiceResponse<EnrolmentViewModel> GetEnrolmentById(string EnrolmentId)
        {
            throw new NotImplementedException();
        }

        public ServiceResponse<bool> UpdateEnrolment(EnrolmentEntity enrolmentEntity)
        {
            ServiceResponse<bool> response = new ServiceResponse<bool>();
            try
            {
                var result = _enrolmentRepository.Update(enrolmentEntity);
                response.ResponseData = result;
                if (result)
                    response.ResponseMessage = "Enrolment data has been Updated.";
                else
                    response.ResponseMessage = "Error while Updating Enrolment, Please try again.";
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
