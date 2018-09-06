using Digi24.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digi24.BusinessLogic.Contracts
{
    public interface IFeesPaymentService
    {
        ServiceResponse<bool> PayFees(FeesPaymentEntity feesData);
    }
}
