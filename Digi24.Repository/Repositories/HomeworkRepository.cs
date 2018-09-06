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
    public class HomeworkRepository : IHomeworkRepository
    {
        private readonly IDbStore _dbStore;
        public HomeworkRepository(IDbStore dbStore)
        {
            _dbStore = dbStore;
        }

        public int Create(HomeWorkEntity entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(object key)
        {
            throw new NotImplementedException();
        }

        public List<HomeWorkEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public HomeWorkEntity GetById(object key)
        {
            throw new NotImplementedException();
        }

        public bool Update(HomeWorkEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
