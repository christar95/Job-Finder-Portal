﻿using Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("Connect")
        {

        }
        
    }
}
