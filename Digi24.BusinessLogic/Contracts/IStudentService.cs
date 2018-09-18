using Digi24.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digi24.BusinessLogic.Contracts
{
    public interface IStudentService
    {
        ServiceResponse<bool> CreateStudent(StudentEntity studentData);
        ServiceResponse<StudentEntity> GetStudentById(int id);
        ServiceResponse<StudentEntity> GetStudentByStandardId(string id);
        ServiceResponse<bool> UpdateStudent(StudentEntity id);
    }
}
