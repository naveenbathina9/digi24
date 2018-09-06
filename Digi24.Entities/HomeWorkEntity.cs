using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digi24.Entities
{
    public class HomeWorkEntity
    {
        public int HomeWorkId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string SubjectId { get; set; }
        public string StandardId { get; set; }
        public DateTime AssignedDate { get; set; }
        public DateTime TargetDate { get; set; }
        public string TeacherId { get; set; }
    }
}
