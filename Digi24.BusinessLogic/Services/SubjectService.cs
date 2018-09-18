using Digi24.BusinessLogic.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Digi24.ViewModels;
using Digi24.Repository.Contracts;
using Digi24.Entities;

namespace Digi24.BusinessLogic.Services
{
    public class SubjectService : ISubjectService
    {
        private readonly ISubjectRepository _subjectRepository;
        public SubjectService(ISubjectRepository subjectRepository)
        {
            _subjectRepository = subjectRepository;
        }

        public ServiceResponse<bool> CreateSubject(string title, string standardId)
        {
            ServiceResponse<bool> response = new ServiceResponse<bool>();
            try
            {
                SubjectEntity entity = new SubjectEntity() { SubjectId = Guid.NewGuid().ToString(), Title = title, StandardId = standardId };
                var result = _subjectRepository.Create(entity);
                response.ResponseData = result > 0;
                response.ResponseMessage = "Created new subject";
            }
            catch (Exception ex)
            {
                response.ResponseMessage = "Unable to create subject, Please try again.";
                response.IsFaulted = true;
            }

            return response;
        }

        public ServiceResponse<SubjectEntity> GetSubjectById(string id)
        {
            ServiceResponse<SubjectEntity> response = new ServiceResponse<SubjectEntity>();
            try
            {
                response.ResponseData = _subjectRepository.GetById(id);
                if (response.ResponseData != null)
                    response.ResponseMessage = "Get Appontment By Id.";
                else
                    response.ResponseMessage = "Unable to get Appointment ById.";
            }
            catch (Exception)
            {
                response.IsFaulted = true;
                response.ResponseMessage = "Internal server error, Please try again.";
                throw;
            }
            return response;
            //var entity = _appointmentRepository.GetById(id);
            //return entity;
        }

       


        public ServiceResponse<List<Subject>> GetAllSubjects()
        {
            ServiceResponse<List<Subject>> response = new ServiceResponse<List<Subject>>();
            List<Subject> allSubjects = new List<Subject>();
            try
            {
                var result = _subjectRepository.GetAll();
                if (result != null)
                {
                    foreach (var item in result)
                    {
                        allSubjects.Add(new Subject() { StandardId = item.StandardId, SubjectId = item.SubjectId, Title = item.Title });
                    }
                    response.ResponseData = allSubjects;
                    response.ResponseMessage = "All subjects are retrieved.";
                }
                else
                {
                    response.ResponseMessage = "Subjects not found.";
                }
            }
            catch (Exception)
            {
                response.ResponseMessage = "Unable to retrive subjects, Please try again.";
                response.IsFaulted = true;
            }

            return response;
        }

        public ServiceResponse<SubjectEntity> GetSubjectMaster(string id)
        {
            ServiceResponse<SubjectEntity> response = new ServiceResponse<SubjectEntity>();
            try
            {
                response.ResponseData = _subjectRepository.GetSubjMaster(id);
                if (response.ResponseData != null)
                    response.ResponseMessage = "Get Appontment By Id.";
                else
                    response.ResponseMessage = "Unable to get Appointment ById.";
            }
            catch (Exception)
            {
                response.IsFaulted = true;
                response.ResponseMessage = "Internal server error, Please try again.";
                throw;
            }
            return response;
            //var entity = _appointmentRepository.GetById(id);
            //return entity;
        }

        public ServiceResponse<SubjectEntity> GetSubjectMasterById(string id)
        {
            ServiceResponse<SubjectEntity> response = new ServiceResponse<SubjectEntity>();
            try
            {
                response.ResponseData = _subjectRepository.GetSubjMaster(id);
                if (response.ResponseData != null)
                    response.ResponseMessage = "Get Appontment By Id.";
                else
                    response.ResponseMessage = "Unable to get Appointment ById.";
            }
            catch (Exception)
            {
                response.IsFaulted = true;
                response.ResponseMessage = "Internal server error, Please try again.";
                throw;
            }
            return response;
            //var entity = _appointmentRepository.GetById(id);
            //return entity;
        }

        public ServiceResponse<bool> UpdateSubject(SubjectEntity id)
        {
            ServiceResponse<bool> response = new ServiceResponse<bool>();
            try
            {
                var result = _subjectRepository.Update(id);
                response.ResponseData = result;
                if (result)
                    response.ResponseMessage = "Student data has been Updated.";
                else
                    response.ResponseMessage = "Error while Updating Student, Please try again.";
            }
            catch (Exception)
            {
                response.IsFaulted = true;
                response.ResponseMessage = "Internal server errror, Please try again.";
            }

            return response;
        }

        public ServiceResponse<bool> UpdateSubjectMaster(SubjectEntity id)
        {
            ServiceResponse<bool> response = new ServiceResponse<bool>();
            try
            {
                var result = _subjectRepository.Update(id);
                response.ResponseData = result;
                if (result)
                    response.ResponseMessage = "Student data has been Updated.";
                else
                    response.ResponseMessage = "Error while Updating Student, Please try again.";
            }
            catch (Exception)
            {
                response.IsFaulted = true;
                response.ResponseMessage = "Internal server errror, Please try again.";
            }

            return response;
        }
    }
}
