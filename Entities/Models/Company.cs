﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime DateFounded { get; set; }
        //Navigation Properties
        //public int JobId { get; set; }
        //public Job AvailableJob { get; set; }

        public Company()
        {
            
        }

    }
}
