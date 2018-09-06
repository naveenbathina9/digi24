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
    public class FeesPaymentService : IFeesPaymentService
    {
        private readonly IFeesPaymentRepository _feesPaymentRepository;
        public FeesPaymentService(IFeesPaymentRepository feesPaymentRepository)
        {
            _feesPaymentRepository = feesPaymentRepository;
        }

        public ServiceResponse<bool> PayFees(FeesPaymentEntity feesData)
        {
            ServiceResponse<bool> response = new ServiceResponse<bool>();
            try
            {
                int result = _feesPaymentRepository.Create(feesData);

                if(result > 0)
                {
                    response.ResponseData = true;
                    response.ResponseMessage = "Payment has been done sucessfully.";
                }else
                {
                    response.ResponseData = false;
                    response.ResponseMessage = "Payment has not been done. Please try again.";
                }
            }
            catch (Exception)
            {
                response.ResponseData = false;
                response.ResponseMessage = "Internal server error, Please try again.";
            }
            return response;
        }
    }
}
