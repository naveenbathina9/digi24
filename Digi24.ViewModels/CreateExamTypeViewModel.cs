using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digi24.ViewModels
{
    public class CreateExamTypeViewModel
    {
        [Required]
        [MinLength(5,  ErrorMessage = "Exam type name should be more than 5 characters.")]
        [MaxLength(30, ErrorMessage = "Exam type name should not exced 30 characters.")]
        public string Title { get; set; }

        [Required( AllowEmptyStrings = false, ErrorMessage ="Exam type description is required.")]
        public string Description { get; set; }
    }

    public class ExamType
    {
        public int ExamTypeId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
