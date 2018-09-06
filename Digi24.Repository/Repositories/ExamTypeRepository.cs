
namespace Digi24.Repository.Repositories
{
    using Contracts;
    using System;
    using System.Collections.Generic;
    using Entities;
    using Infrastructure;

    public class ExamTypeRepository : IExamTypeRepository
    {
        #region Stored Procedure Names
        private const string SP_CREATE_EXAM_TYPE = "SP_CreateExamType";
        private const string SP_GET_ALL_EXAM_TYPES = "SP_GetAllExamTypes";
        #endregion

        private readonly IDbStore _dbStore;
        public ExamTypeRepository(IDbStore dbStore)
        {
            _dbStore = dbStore;
        }

        public int Create(ExamTypeEntity entity)
        {
            int examTypeId = 0;
            try
            {
                //using (_dbStore)
                //{
                var parameters = ParameterUtility.CreateParameterFromClassObject(entity);
                parameters.Remove("ExamTypeId", entity.ExamTypeId);
                examTypeId = (int)_dbStore.ExecuteNonQueryStoredProcedure(SP_CREATE_EXAM_TYPE, parameters);
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return examTypeId;
        }

        public bool Delete(object key)
        {
            throw new NotImplementedException();
        }

        public List<ExamTypeEntity> GetAll()
        {
            List<ExamTypeEntity> examTypesList = null;
            try
            {
                var resultDataSet = _dbStore.ExecuteStoredProcWithDataAdapter(SP_GET_ALL_EXAM_TYPES, null);

                if (resultDataSet.Tables.Count > 0)
                {
                    examTypesList = resultDataSet.Tables[0].ToList<ExamTypeEntity>(new ExamTypeEntity());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return examTypesList;
        }

        public ExamTypeEntity GetById(object key)
        {
            throw new NotImplementedException();
        }

        public bool Update(ExamTypeEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
