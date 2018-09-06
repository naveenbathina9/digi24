
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digi24.Entities
{
    public class StudentEntity
    {
        public string StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string ParentEmailAddress{ get; set; }
        public string ParentMobileNumber { get; set; }
        public string ProfilePicture { get; set; }
        public string StandardId { get; set; }
    }
}
