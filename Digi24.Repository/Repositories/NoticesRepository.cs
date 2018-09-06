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
    public class NoticesRepository : INoticesRepository
    {
        private readonly IDbStore _dbStore;
        public NoticesRepository(IDbStore dbStore)
        {
            _dbStore = dbStore;
        }

        public int Create(NoticesEntity entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(object key)
        {
            throw new NotImplementedException();
        }

        public List<NoticesEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public NoticesEntity GetById(object key)
        {
            throw new NotImplementedException();
        }

        public bool Update(NoticesEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
