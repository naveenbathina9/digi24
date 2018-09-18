using Digi24.BusinessLogic.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Digi24.Entities;
using Digi24.Repository.Contracts;

namespace Digi24.BusinessLogic.Services
{
    public class HomeworkService : IHomeworkService
    {
        private readonly IHomeworkRepository _homeworkRepository;
        public HomeworkService(IHomeworkRepository homeworkRepository)
        {
            _homeworkRepository = homeworkRepository;
        }
        public ServiceResponse<bool> CreateHomework(HomeWorkEntity homeworkData)
        {
            ServiceResponse<bool> response = new ServiceResponse<bool>();
            try
            {
                var result = _homeworkRepository.Create(homeworkData);

                if (result > 0)
                {
                    response.ResponseData = result > 0;
                    response.ResponseMessage = "Created Homework.";
                }
                else
                {
                    response.ResponseData = result > 0;
                    response.ResponseMessage = "Homework has not been created, Please try again.";
                }
            }
            catch (Exception)
            {
                response.IsFaulted = true;
                response.ResponseMessage = "Intenal Server error. Please try again.";
            }
            return response;
        }

        public ServiceResponse<HomeWorkEntity> GetHomeWorkById(string SubjId, string standId, DateTime date)
        {
            ServiceResponse<HomeWorkEntity> response = new ServiceResponse<HomeWorkEntity>();
            try
            {
                response.ResponseData = _homeworkRepository.GetByids(SubjId, standId, date);
                if (response.ResponseData != null)
                    response.ResponseMessage = "Get HomeWork By Id.";
                else
                    response.ResponseMessage = "Unable to get HomeWork ById.";
            }
            catch (Exception)
            {
                response.IsFaulted = true;
                response.ResponseMessage = "Internal server error, Please try again.";
                throw;
            }
            return response;
        }

        public ServiceResponse<bool> UpdateHomeWork(HomeWorkEntity HomeWorkData)
        {
            ServiceResponse<bool> response = new ServiceResponse<bool>();
            try
            {
                var result = _homeworkRepository.Update(HomeWorkData);
                response.ResponseData = result;
                if (result)
                    response.ResponseMessage = "HomeWork data has been Updated.";
                else
                    response.ResponseMessage = "Error while Updating HomeWork, Please try again.";
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
