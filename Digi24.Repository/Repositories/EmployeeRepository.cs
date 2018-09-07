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
            int result = -1;
            try
            {
                var dbParams = ParameterUtility.CreateParameterFromClassObject(entity);
                result = (int)_dbStore.ExecuteNonQueryStoredProcedure("[dbo].[SP_CreateEmployee]", dbParams);
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

        public List<EmployeeEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public EmployeeEntity GetById(object key)
        {
            List<EmployeeEntity> employees = null;
            try
            {
                var parameters = new DbParameters();
                parameters.Add("@EmployeeId", key);
                var resultDataSet = _dbStore.ExecuteStoredProcWithDataAdapter("[dbo].[SP_GetEmployeeById]", parameters);
                if (resultDataSet.Tables.Count > 0)
                {
                    employees = resultDataSet.Tables[0].ToList<EmployeeEntity>(new EmployeeEntity());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return employees?.FirstOrDefault();
        }

        public bool Update(EmployeeEntity entity)
        {
            int result = -1;
            try
            {
                var dbParams = ParameterUtility.CreateParameterFromClassObject(entity);
                result = (int)_dbStore.ExecuteNonQueryStoredProcedure("[dbo].[SP_UpdateEmployee]", dbParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
    }
}
