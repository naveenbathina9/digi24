using Digi24.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Digi24.Entities;
using Digi24.Repository.Infrastructure;

namespace Digi24.Repository.Repositories
{
    public class ExaminationRepository : IExaminationRepository
    {
        private readonly IDbStore _dbStore;
        public ExaminationRepository(IDbStore dbStore)
        {
            _dbStore = dbStore;
        }

        public int Create(ExaminationEntity entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(object key)
        {
            throw new NotImplementedException();
        }

        public List<ExaminationEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public ExaminationEntity GetById(object key)
        {
            throw new NotImplementedException();
        }

        public bool Update(ExaminationEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
