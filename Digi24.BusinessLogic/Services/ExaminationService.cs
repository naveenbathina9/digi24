using Digi24.BusinessLogic.Contracts;
using Digi24.Entities;
using Digi24.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digi24.BusinessLogic.Services
{
    public class ExaminationService : IExaminationService
    {

        private readonly IExaminationRepository _examinationRepository;
        public ExaminationService(IExaminationRepository examinationRepository)
        {
            _examinationRepository = examinationRepository;
        }
        public ServiceResponse<bool> CreateExamination(ExaminationEntity examinationEntity)
        {
            ServiceResponse<bool> response = new ServiceResponse<bool>();
            try
            {
                int result = _examinationRepository.Create(examinationEntity);
                if (result > 0)
                {
                    response.ResponseData = result > 0;
                    response.ResponseMessage = "examination created succesfully.";
                }
                else
                {
                    response.ResponseData = result > 0;
                    response.ResponseMessage = "examination is not created, Please try again.";
                }
            }
            catch (Exception)
            {
                response.IsFaulted = true;
                response.ResponseMessage = "examination is not created, Internal error.";
            }
            return response;
        }

        public ServiceResponse<ExaminationEntity> GetExaminationByAcdYear(int id)
        {
            ServiceResponse<ExaminationEntity> response = new ServiceResponse<ExaminationEntity>();
            try
            {
                response.ResponseData = _examinationRepository.GetExamByAcademicYear(id);
                if (response.ResponseData != null)
                    response.ResponseMessage = "Get Examinatio Academic Year.";
                else
                    response.ResponseMessage = "Unable to get Examination Academic Year.";
            }
            catch (Exception)
            {
                response.IsFaulted = true;
                response.ResponseMessage = "Internal server error, Please try again.";
                throw;
            }
            return response;
        }

        public ServiceResponse<ExaminationEntity> GetExaminationByExType(int id)
        {
            ServiceResponse<ExaminationEntity> response = new ServiceResponse<ExaminationEntity>();
            try
            {
                response.ResponseData = _examinationRepository.GetExamByExamType(id);
                if (response.ResponseData != null)
                    response.ResponseMessage = "Get Examinatio Exam Year.";
                else
                    response.ResponseMessage = "Unable to get Examination Exam Year.";
            }
            catch (Exception)
            {
                response.IsFaulted = true;
                response.ResponseMessage = "Internal server error, Please try again.";
                throw;
            }
            return response;
        }

        public ServiceResponse<bool> UpdateExamination(ExaminationEntity id)
        {
            ServiceResponse<bool> response = new ServiceResponse<bool>();
            try
            {
                var result = _examinationRepository.Update(id);
                response.ResponseData = result;
                if (result)
                    response.ResponseMessage = "Appointment data has been Updated.";
                else
                    response.ResponseMessage = "Error while Updating Appointment, Please try again.";
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
