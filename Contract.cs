﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_task_3
{
    internal class Contract
    {
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string TimeZone { get; set; }
    }
}