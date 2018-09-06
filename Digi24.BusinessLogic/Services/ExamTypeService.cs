using Digi24.BusinessLogic.Contracts;
using Digi24.Entities;
using Digi24.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Digi24.ViewModels;

namespace Digi24.BusinessLogic.Services
{
    public class ExamTypeService : IExamTypeService
    {
        private readonly IExamTypeRepository _repository;
        public ExamTypeService(IExamTypeRepository repository)
        {
            _repository = repository;
        }

        public ServiceResponse<bool> CreateExamType(string title, string description)
        {
            ServiceResponse<bool> response = new ServiceResponse<bool>();
            try
            {
                var examType = new ExamTypeEntity() { Title = title, Description = description };
                var result = _repository.Create(examType);
                response.ResponseData = result > 0;
                response.ResponseMessage = "Success";
            }
            catch (Exception ex)
            {
                response.ResponseMessage = "Error while creationg exam type.";
                //Log Exeception
                //throw ex;
            }
            return response;
        }

        public ServiceResponse<List<ExamType>> GetAllExamTypes()
        {
            ServiceResponse<List<ExamType>> response = new ServiceResponse<List<ExamType>>(); 
            try
            {
                var entities = _repository.GetAll();
                if (entities != null)
                {
                    List<ExamType> examtypes = new List<ExamType>();
                    foreach (var item in entities)
                    {
                        examtypes.Add(new ExamType() { ExamTypeId = item.ExamTypeId, Title = item.Title, Description = item.Description });
                    }
                    response.ResponseData = examtypes;
                    response.ResponseMessage = "Exam types are fetched";
                }else
                {
                    response.ResponseMessage = "No records";
                }
            }
            catch (Exception)
            {
                response.IsFaulted = true;
                response.ResponseMessage = "Unable to process query";
            }
            return response;
        }
    }
}
