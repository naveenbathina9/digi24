﻿using Digi24.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Digi24.Entities;
using Digi24.Repository.Infrastructure;

namespace Digi24.Repository.Repositories
{
    public class EnrolmentRepository : IEnrolmentRepository
    {
        private readonly IDbStore _dbStore;
        public EnrolmentRepository(IDbStore dbStore)
        {
            _dbStore = dbStore;
        }

        public int Create(EnrolmentEntity entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(object key)
        {
            throw new NotImplementedException();
        }

        public List<EnrolmentEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public EnrolmentEntity GetById(object key)
        {
            throw new NotImplementedException();
        }

        public bool Update(EnrolmentEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
