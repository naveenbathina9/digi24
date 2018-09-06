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
    public class SubjectRepository : ISubjectRepository
    {
        private const string SP_CREATE_SUBJECT = "SP_CreateSubject";
        private const string SP_GET_ALL_SUBJECTS = "SP_GetAllSubjects";

        private readonly IDbStore _dbStore;
        public SubjectRepository(IDbStore dbStore)
        {
            _dbStore = dbStore;
        }
        public int Create(SubjectEntity entity)
        {
            int result = 0;
            try
            {
                var parameters = ParameterUtility.CreateParameterFromClassObject(entity);
                result = (int)_dbStore.ExecuteNonQueryStoredProcedure(SP_CREATE_SUBJECT, parameters);
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

        public List<SubjectEntity> GetAll()
        {
            List<SubjectEntity> subjectList = null;
            try
            {
                var resultDataSet = _dbStore.ExecuteStoredProcWithDataAdapter(SP_GET_ALL_SUBJECTS, null);

                if (resultDataSet.Tables.Count > 0)
                {
                    subjectList = resultDataSet.Tables[0].ToList<SubjectEntity>(new SubjectEntity());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return subjectList;
        }

        public SubjectEntity GetById(object key)
        {
            throw new NotImplementedException();
        }

        public bool Update(SubjectEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
