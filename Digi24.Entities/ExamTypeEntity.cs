using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digi24.Entities
{
    public class ExamTypeEntity
    {
        public int ExamTypeId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }


    public class CreateExamTypeEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
