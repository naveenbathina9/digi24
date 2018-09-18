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
            try
            {
                var parameters = ParameterUtility.CreateParameterFromClassObject(entity);
                //parameters.Remove("Status", entity.Status);
                parameters.Remove("HomeWorkId", entity.HomeWorkId);
                var result = (int)_dbStore.ExecuteNonQueryStoredProcedure("SP_InsertHomeWork", parameters);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
            List<HomeWorkEntity> homeWork = null;
            try
            {
                var parameters = new DbParameters();
                parameters.Add("@HomeWorkId", key);
                var resultDataSet = _dbStore.ExecuteStoredProcWithDataAdapter("SP_SelectHomeWork", parameters);
                if (resultDataSet.Tables.Count > 0)
                {
                    homeWork = resultDataSet.Tables[0].ToList<HomeWorkEntity>(new HomeWorkEntity());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return homeWork?.FirstOrDefault();
        }

        public HomeWorkEntity GetByids(string SubjId, string standId, DateTime date)
        {
            List<HomeWorkEntity> homeWork = null;
            try
            {
                var parameters = new DbParameters();
                parameters.Add("@SubjectId", SubjId);
                parameters.Add("@StandardId", standId);
                parameters.Add("@AssignedDate", date);
                var resultDataSet = _dbStore.ExecuteStoredProcWithDataAdapter("SP_SelectHomeWork", parameters);
                if (resultDataSet.Tables.Count > 0)
                {
                    homeWork = resultDataSet.Tables[0].ToList<HomeWorkEntity>(new HomeWorkEntity());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return homeWork?.FirstOrDefault();
        }

        public bool Update(HomeWorkEntity entity)
        {
            int result = -1;
            try
            {
                var parameters = ParameterUtility.CreateParameterFromClassObject(entity);
                //parameters.Remove("ExaminationId", entity.ExaminationId);
                //parameters.Remove("AppointmentId", entity.AppointmentId);
                result = (int)_dbStore.ExecuteNonQueryStoredProcedure("SP_UpdateHomeWork", parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0; throw new NotImplementedException();
        }
    }
}
