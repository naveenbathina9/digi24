﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digi24.Entities
{
    public class NoticesEntity
    {
        public int NoticeId { get; set; }
        public DateTime NoticeDate { get; set; }
        public DateTime TargetDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Priority { get; set; }
    }
}
