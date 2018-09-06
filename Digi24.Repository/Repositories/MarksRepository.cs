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
    public class MarksRepository : IMarksRepository
    {
        private readonly IDbStore _dbStore;
        public MarksRepository(IDbStore dbStore)
        {
            _dbStore = dbStore;
        }
        public int Create(MarksEntity entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(object key)
        {
            throw new NotImplementedException();
        }

        public List<MarksEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public MarksEntity GetById(object key)
        {
            throw new NotImplementedException();
        }

        public bool Update(MarksEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
