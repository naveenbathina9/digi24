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
    public class MarksListService : IMarksListService
    {
        private readonly IMarksListRepository _marksListRepository;
        public MarksListService(IMarksListRepository marksListRepository)
        {
            _marksListRepository = marksListRepository;
        }

        public ServiceResponse<bool> CreateMarksList(MarksListEntity marksListEntity)
        {
            ServiceResponse<bool> response = new ServiceResponse<bool>();
            try
            {
                var result = _marksListRepository.Create(marksListEntity) > 0;
                response.ResponseData = result;
                if (result)
                    response.ResponseMessage = "New MarksList has been created.";
                else
                    response.ResponseMessage = "Error while creating MarksList, Please try again.";
            }
            catch (Exception)
            {
                response.IsFaulted = true;
                response.ResponseMessage = "Internal server errror, Please try again.";
            }

            return response;
        }

        public ServiceResponse<bool> UpdateMarksList(MarksListEntity marksListEntity)
        {
            throw new NotImplementedException();
        }
    }
}
