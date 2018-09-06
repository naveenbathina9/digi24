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
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IDbStore _dbStore;
        public EmployeeRepository(IDbStore dbStore)
        {
            _dbStore = dbStore;
        }

        public int Create(EmployeeEntity entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(object key)
        {
            throw new NotImplementedException();
        }

        public List<EmployeeEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public EmployeeEntity GetById(object key)
        {
            throw new NotImplementedException();
        }

        public bool Update(EmployeeEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
