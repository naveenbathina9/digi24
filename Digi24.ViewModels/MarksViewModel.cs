using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digi24.ViewModels
{
    public class MarksViewModel
    {
        public int MarksId { get; set; }
        public int MarksListId { get; set; }
        public string StudentId { get; set; }
        public int TotalMarks { get; set; }
        public float AchievedMarks { get; set; }
    }
}
