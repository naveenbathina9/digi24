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
    public class FeesPaymentRepository : IFeesPaymentRepository
    {
        private readonly IDbStore _dbStore;
        public FeesPaymentRepository(IDbStore dbStore)
        {
            _dbStore = dbStore;
        }

        public int Create(FeesPaymentEntity entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(object key)
        {
            throw new NotImplementedException();
        }

        public List<FeesPaymentEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public FeesPaymentEntity GetById(object key)
        {
            throw new NotImplementedException();
        }

        public bool Update(FeesPaymentEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
