using Digi24.Entities;
using Digi24.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digi24.Repository.Contracts
{
    public interface ISubjectRepository : IRepository<SubjectEntity>
    {
        SubjectEntity GetSubjMaster(string StandardId);
    }
}
