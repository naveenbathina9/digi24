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
    public class ExaminationRepository : IExaminationRepository
    {
        private readonly IDbStore _dbStore;
        public ExaminationRepository(IDbStore dbStore)
        {
            _dbStore = dbStore;
        }

        public int Create(ExaminationEntity entity)
        {
            try
            {
                var parameters = ParameterUtility.CreateParameterFromClassObject(entity);
                parameters.Remove("ExamimationId", entity.ExamimationId);
                var result = (int)_dbStore.ExecuteNonQueryStoredProcedure("SP_InsertExamimation", parameters);
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

        public List<ExaminationEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public ExaminationEntity GetById(object key)
        {
            List<ExaminationEntity> examination = null;
            try
            {
                var parameters = new DbParameters();
                parameters.Add("@ExamimationId", key);
                var resultDataSet = _dbStore.ExecuteStoredProcWithDataAdapter("SP_GetExamimationByExamType", parameters);
                if (resultDataSet.Tables.Count > 0)
                {
                    examination = resultDataSet.Tables[0].ToList<ExaminationEntity>(new ExaminationEntity());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return examination?.FirstOrDefault();
        }

        public ExaminationEntity GetExamByAcademicYear(int AcademicYear)
        {
            List<ExaminationEntity> examination = null;
            try
            {
                var parameters = new DbParameters();
                parameters.Add("@AcademicYear", AcademicYear);
                var resultDataSet = _dbStore.ExecuteStoredProcWithDataAdapter("SP_GetExamimationByAcademicYear", parameters);
                if (resultDataSet.Tables.Count > 0)
                {
                    examination = resultDataSet.Tables[0].ToList<ExaminationEntity>(new ExaminationEntity());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return examination?.FirstOrDefault();
        }

        public ExaminationEntity GetExamByExamType(int ExamTypeId)
        {
            List<ExaminationEntity> examination = null;
            try
            {
                var parameters = new DbParameters();
                parameters.Add("@ExamTypeId", ExamTypeId);
                var resultDataSet = _dbStore.ExecuteStoredProcWithDataAdapter("SP_GetExamimationByExamType", parameters);
                if (resultDataSet.Tables.Count > 0)
                {
                    examination = resultDataSet.Tables[0].ToList<ExaminationEntity>(new ExaminationEntity());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return examination?.FirstOrDefault();
        }

        public bool Update(ExaminationEntity entity)
        {
            int result = -1;
            try
            {
                var parameters = ParameterUtility.CreateParameterFromClassObject(entity);
                //parameters.Remove("ExaminationId", entity.ExaminationId);
                //parameters.Remove("AppointmentId", entity.AppointmentId);
                result = (int)_dbStore.ExecuteNonQueryStoredProcedure("SP_UpdateExamimation", parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
    }
}
