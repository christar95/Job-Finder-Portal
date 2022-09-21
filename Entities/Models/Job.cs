using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Job
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

        //Navigation Properties
        public Company Company { get; set; }
        

        //Constructor
        public Job()
        {

        }

    }
}
