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
    public class AttendanceRepository : IAttendanceRepository
    {
        private readonly IDbStore _dbStore;
        public AttendanceRepository(IDbStore dbStore)
        {
            _dbStore = dbStore;
        }
        public int Create(AttendanceEntity entity)
        {
            int result = -1;
            try
            {
                var dbParams = ParameterUtility.CreateParameterFromClassObject(entity);
                result = (int)_dbStore.ExecuteStoredProcedure("SP_CreateAttendance", dbParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public bool Delete(object key)
        {
            throw new NotImplementedException();
        }

        public List<AttendanceEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public AttendanceEntity GetById(object key)
        {
            throw new NotImplementedException();
        }

        public bool Update(AttendanceEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
