using Digi24.Entities;
using Digi24.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digi24.BusinessLogic.Contracts
{
    public interface ISubjectService
    {
        ServiceResponse<bool> CreateSubject(string title, string standardId);
        ServiceResponse<List<Subject>> GetAllSubjects();
        ServiceResponse<SubjectEntity> GetSubjectById(string id);
        ServiceResponse<SubjectEntity> GetSubjectMaster(string id);
        ServiceResponse<SubjectEntity> GetSubjectMasterById(string id);
        ServiceResponse<bool> UpdateSubject(SubjectEntity id);
        ServiceResponse<bool> UpdateSubjectMaster(SubjectEntity id);
    }
}
