﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupProjectCB16.Models
{
    public class CompanyDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public ApplicationUser User { get; set; }
    }
}