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
    public class StandardRepository : IStandardRepository
    {
        private readonly IDbStore _dbStore;
        public StandardRepository(IDbStore dbStore)
        {
            _dbStore = dbStore;
        }

        public int Create(StandardEntity entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(object key)
        {
            throw new NotImplementedException();
        }

        public List<StandardEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public StandardEntity GetById(object key)
        {
            throw new NotImplementedException();
        }

        public bool Update(StandardEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
