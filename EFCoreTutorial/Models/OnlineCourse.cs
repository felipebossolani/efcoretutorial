﻿using System;
using System.Collections.Generic;

namespace EFCoreTutorial.Models
{
    public partial class OnlineCourse
    {
        public int CourseId { get; set; }
        public string Url { get; set; }

        public virtual Course Course { get; set; }
    }
}
