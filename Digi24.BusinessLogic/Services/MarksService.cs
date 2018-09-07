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
    public class MarksService : IMarksService
    {
        private readonly IMarksRepository _marksRepository;
        public MarksService(IMarksRepository marksRepository)
        {
            _marksRepository = marksRepository;
        }
        public ServiceResponse<bool> CreateMarks(MarksEntity marksEntity)
        {
            ServiceResponse<bool> response = new ServiceResponse<bool>();
            try
            {
                var result = _marksRepository.Create(marksEntity) > 0;
                response.ResponseData = result;
                if (result)
                    response.ResponseMessage = "New Marks has been created.";
                else
                    response.ResponseMessage = "Error while creating Marks, Please try again.";
            }
            catch (Exception)
            {
                response.IsFaulted = true;
                response.ResponseMessage = "Internal server errror, Please try again.";
            }

            return response;
        }

        public ServiceResponse<MarksViewModel> GetMarksByStudentId(string EmployeeId)
        {
            var entity = _marksRepository.GetById(EmployeeId);
            ServiceResponse<MarksViewModel> serviceResponse = new ServiceResponse<MarksViewModel>();

            MarksViewModel details = new MarksViewModel()
            {
               MarksId = entity.MarksId,
               MarksListId = entity.MarksListId,
               StudentId = entity.StudentId,
               TotalMarks = entity.TotalMarks,
               AchievedMarks = entity.AchievedMarks
            };
            serviceResponse.ResponseData = details;
            serviceResponse.ResponseMessage = "Retrieved Student Marks.";
            return serviceResponse;
        }

        public ServiceResponse<bool> UpdateMarks(MarksEntity marksEntity)
        {
            ServiceResponse<bool> response = new ServiceResponse<bool>();
            try
            {
                var result = _marksRepository.Update(marksEntity);
                response.ResponseData = result;
                if (result)
                    response.ResponseMessage = "Marks data has been Updated.";
                else
                    response.ResponseMessage = "Error while Updating Marks, Please try again.";
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
