using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digi24.ViewModels
{
    public class Subject
    {
        public string SubjectId { get; set; }
        public string Title { get; set; }
        public string StandardId { get; set; }
    }

    public class CreateSubjectViewModel
    {
        public string Title { get; set; }
        public string StandardId { get; set; }
    }
}
