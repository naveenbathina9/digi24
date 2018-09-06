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
    public class ExamTimeTableRepository : IExamTimeTableRepository
    {
        private readonly IDbStore _dbStore;
        public ExamTimeTableRepository(IDbStore dbStore)
        {
            _dbStore = dbStore;
        }

        public int Create(ExamTimeTableEntity entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(object key)
        {
            throw new NotImplementedException();
        }

        public List<ExamTimeTableEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public ExamTimeTableEntity GetById(object key)
        {
            throw new NotImplementedException();
        }

        public bool Update(ExamTimeTableEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
