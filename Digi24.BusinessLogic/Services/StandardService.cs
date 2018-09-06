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
    public class StandardService : IStandardService
    {
        private readonly IStandardRepository _standardRepository;
        public StandardService(IStandardRepository standardRepository)
        {
            _standardRepository = standardRepository;
        }

        public ServiceResponse<bool> Create(StandardEntity standardData)
        {
            ServiceResponse<bool> response = new ServiceResponse<bool>();
            try
            {
                int result = _standardRepository.Create(standardData);
                response.ResponseData = result >0;
                if(result> 0)
                {
                    response.ResponseMessage = "New standard has been created.";
                }else
                {
                    response.ResponseMessage = "There was a problem in createing standard, Please try again.";
                }
            }
            catch (Exception)
            {
                response.IsFaulted = true;
                response.ResponseMessage = "Internal server error, Please try again.";
            }
            return response;
        }
    }
}
