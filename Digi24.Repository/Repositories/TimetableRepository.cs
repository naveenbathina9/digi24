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
    public class TimetableRepository : ITimetableRepository
    {
        private readonly IDbStore _dbStore;
        public TimetableRepository(IDbStore dbStore)
        {
            _dbStore = dbStore;
        }

        public int Create(TimeTableEntity entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(object key)
        {
            throw new NotImplementedException();
        }

        public List<TimeTableEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TimeTableEntity GetById(object key)
        {
            throw new NotImplementedException();
        }

        public bool Update(TimeTableEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
