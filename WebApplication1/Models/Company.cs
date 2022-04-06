﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}