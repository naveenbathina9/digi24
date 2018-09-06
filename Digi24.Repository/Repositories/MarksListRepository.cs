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
    public class MarksListRepository : IMarksListRepository
    {
        private readonly IDbStore _dbStore;
        public MarksListRepository(IDbStore dbStore)
        {
            _dbStore = dbStore;
        }

        public int Create(MarksListEntity entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(object key)
        {
            throw new NotImplementedException();
        }

        public List<MarksListEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public MarksListEntity GetById(object key)
        {
            throw new NotImplementedException();
        }

        public bool Update(MarksListEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
