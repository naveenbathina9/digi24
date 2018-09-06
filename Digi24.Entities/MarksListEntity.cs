using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digi24.Entities
{
    public class MarksListEntity
    {
        public int MarksListId { get; set; }
        public string UploadedBy { get; set; }
        public DateTime UploadedDate { get; set; }
        public int ExaminationId { get; set; }
        public string StandardId { get; set; }
        public string SubjectId { get; set; }
    }
}
