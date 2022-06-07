﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
