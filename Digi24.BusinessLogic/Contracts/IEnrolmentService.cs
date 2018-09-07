using Digi24.Entities;
using Digi24.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digi24.BusinessLogic.Contracts
{
    public interface IEnrolmentService
    {
        ServiceResponse<bool> CreateEnrolment(EnrolmentEntity enrolmentEntity);
        ServiceResponse<bool> UpdateEnrolment(EnrolmentEntity enrolmentEntity);
        ServiceResponse<EnrolmentViewModel> GetEnrolmentById(String EnrolmentId);
    }
}
