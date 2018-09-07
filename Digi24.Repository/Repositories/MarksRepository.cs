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
            int result = -1;
            try
            {
                var dbParams = ParameterUtility.CreateParameterFromClassObject(entity);
                dbParams.Remove("MarksId", entity.MarksId);
                result = (int)_dbStore.ExecuteNonQueryStoredProcedure("[dbo].[SP_InsertMarks]", dbParams);
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

        public List<MarksEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public MarksEntity GetById(object key)
        {
            List<MarksEntity> marks = null;
            try
            {
                var parameters = new DbParameters();
                parameters.Add("@EmployeeId", key);
                var resultDataSet = _dbStore.ExecuteStoredProcWithDataAdapter("[dbo].[SP_GetMarksByStudent]", parameters);
                if (resultDataSet.Tables.Count > 0)
                {
                    marks = resultDataSet.Tables[0].ToList<MarksEntity>(new MarksEntity());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return marks?.FirstOrDefault();
        }

        public bool Update(MarksEntity entity)
        {
            int result = -1;
            try
            {
                var dbParams = ParameterUtility.CreateParameterFromClassObject(entity);
                result = (int)_dbStore.ExecuteNonQueryStoredProcedure("[dbo].[SP_UpdateMarks]", dbParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
    }
}
