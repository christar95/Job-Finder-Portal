using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entities.Enums;

namespace GroupProjectCB16.Models
{
    public class JobViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Specialty { get; set; }
        public string Description { get; set; }
        public WorkPlace WorkPlace { get; set; }
        public string Region { get; set; }
        public EmploymentType EmploymentType { get; set; }
        public DateTime DatePosted { get; set; }
        public decimal? Salary { get; set; }

        
        public string UserId { get; set; }


    }
}