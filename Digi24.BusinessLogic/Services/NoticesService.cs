using Digi24.BusinessLogic.Contracts;
using Digi24.Repository.Contracts;
using Digi24.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Digi24.Entities;

namespace Digi24.BusinessLogic.Services
{
    public class NoticesService : INoticesService
    {
        private readonly INoticesRepository _noticesRepository;
        public NoticesService(INoticesRepository noticesRepository)
        {
            _noticesRepository = noticesRepository;
        }

        public ServiceResponse<bool> CreateNotice(NoticesEntity noticeData)
        {
            ServiceResponse<bool> response = new ServiceResponse<bool>();
            try
            {
                var result = _noticesRepository.Create(noticeData);

                if(result > 0)
                {
                    response.ResponseData = result > 0;
                    response.ResponseMessage = "Created Notice.";
                }else
                {
                    response.ResponseData = result > 0;
                    response.ResponseMessage = "Error while creating notice, Please try again.";
                }
            }
            catch (Exception ex)
            {
                response.IsFaulted = true;
                response.ResponseMessage = "Error while creating notice, Please try again.";
            }
            return response;
        }
    }
}
