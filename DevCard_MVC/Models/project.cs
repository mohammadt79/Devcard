﻿using System;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_MVC.Models
{
    public class project
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Client { get; set; }
    }
}