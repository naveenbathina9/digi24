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
            try
            {
                var parameters = ParameterUtility.CreateParameterFromClassObject(entity);
                var result = (int)_dbStore.ExecuteNonQueryStoredProcedure("SP_InsertStudents", parameters);
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

        public List<StudentEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public StudentEntity GetById(object key)
        {
            List<StudentEntity> student = null;
            try
            {
                var parameters = new DbParameters();
                parameters.Add("@StudentId", key);
                var resultDataSet = _dbStore.ExecuteStoredProcWithDataAdapter("SP_GetStudentById", parameters);
                if (resultDataSet.Tables.Count > 0)
                {
                    student = resultDataSet.Tables[0].ToList<StudentEntity>(new StudentEntity());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return student?.FirstOrDefault();
        }

        public StudentEntity GetStudentByStandardId(string StandardId)
        {
            List<StudentEntity> student = null;
            try
            {
                var parameters = new DbParameters();
                parameters.Add("@StandardId", StandardId);
                var resultDataSet = _dbStore.ExecuteStoredProcWithDataAdapter("SP_GetStudentsByStandardId", parameters);
                if (resultDataSet.Tables.Count > 0)
                {
                    student = resultDataSet.Tables[0].ToList<StudentEntity>(new StudentEntity());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return student?.FirstOrDefault();
        }

        public bool Update(StudentEntity entity)
        {
            int result = -1;
            try
            {
                var parameters = ParameterUtility.CreateParameterFromClassObject(entity);
                result = (int)_dbStore.ExecuteNonQueryStoredProcedure("SP_UpdateStudentById", parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
    }
}
