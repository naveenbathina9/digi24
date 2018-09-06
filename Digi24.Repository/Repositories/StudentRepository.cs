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
    public class StudentRepository : IStudentRepository
    {
        private readonly IDbStore _dbStore;
        public StudentRepository(IDbStore dbStore)
        {
            _dbStore = dbStore;
        }
        public int Create(StudentEntity entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(object key)
        {
            throw new NotImplementedException();
        }

        public List<StudentEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public StudentEntity GetById(object key)
        {
            throw new NotImplementedException();
        }

        public bool Update(StudentEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
