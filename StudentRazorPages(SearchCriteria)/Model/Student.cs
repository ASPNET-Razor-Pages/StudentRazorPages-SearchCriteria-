﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRazorPages_SearchCriteria_.Model
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ImagePath { get; set; }

        public Section Section { get; set; }
    }
}
