using System;
using System.Collections.Generic;
using System.Linq;

namespace Digi24.Repository.Repositories
{
    using Contracts;
    using Entities;
    using Infrastructure;

    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly IDbStore _dbStore;
        public AppointmentRepository(IDbStore dbStore)
        {
            _dbStore = dbStore;
        }

        public int RejectAppointment(int appointmentId)
        {
            int result = -1;
            try
            {
                DbParameters dbParam = new DbParameters();
                dbParam.Add("@AppointmentId", appointmentId);
                result = (int)_dbStore.ExecuteNonQueryStoredProcedure("[dbo].[SP_RejectAppointment]", dbParam);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public int AcceptAppointment(int appointmentId)
        {
            int result = -1;
            try
            {
                DbParameters dbParam = new DbParameters();
                dbParam.Add("@AppointmentId", appointmentId);
                result = (int)_dbStore.ExecuteNonQueryStoredProcedure("[dbo].[SP_AcceptAppointment]", dbParam);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        /// <summary>
        /// Creates appointment
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int Create(AppointmentEntity entity)
        {
            try
            {
                var parameters = ParameterUtility.CreateParameterFromClassObject(entity);
                parameters.Remove("Status", entity.Status);
                parameters.Remove("AppointmentId", entity.AppointmentId);
                var result = (int)_dbStore.ExecuteNonQueryStoredProcedure("SP_CreateAppointment", parameters);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Deletes appointment
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool Delete(object key)
        {
            try
            {
                var parameters = new DbParameters();
                parameters.Add("@AppointmentId", key);
                var result = (int)_dbStore.ExecuteNonQueryStoredProcedure("SP_DeleteAppointment", parameters);
                return result > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get all appointments
        /// </summary>
        /// <returns></returns>
        public List<AppointmentEntity> GetAll()
        {
            List<AppointmentEntity> appointments = null;
            try
            {
                var resultDataSet = _dbStore.ExecuteStoredProcWithDataAdapter("SP_GetAllAppointments", null);
                if (resultDataSet.Tables.Count > 0)
                {
                    appointments = resultDataSet.Tables[0].ToList<AppointmentEntity>(new AppointmentEntity());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return appointments;
        }

        /// <summary>
        /// Get appointment by id.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public AppointmentEntity GetById(object key)
        {
            List<AppointmentEntity> appointments = null;
            try
            {
                var parameters = new DbParameters();
                parameters.Add("@AppointmentId", key);
                var resultDataSet = _dbStore.ExecuteStoredProcWithDataAdapter("SP_GetAppointmentById", parameters);
                if (resultDataSet.Tables.Count > 0)
                {
                    appointments = resultDataSet.Tables[0].ToList<AppointmentEntity>(new AppointmentEntity());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return appointments?.FirstOrDefault();
        }

        /// <summary>
        /// Update appointment.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Update(AppointmentEntity entity)
        {
            int result = -1;
            try
            {
                var parameters = ParameterUtility.CreateParameterFromClassObject(entity);
                parameters.Remove("Status", entity.Status);
                //parameters.Remove("AppointmentId", entity.AppointmentId);
                result = (int)_dbStore.ExecuteNonQueryStoredProcedure("SP_UpdateAppointment", parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
    }
}
