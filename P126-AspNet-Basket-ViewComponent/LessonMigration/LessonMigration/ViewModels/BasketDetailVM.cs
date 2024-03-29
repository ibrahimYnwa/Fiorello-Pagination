﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LessonMigration.ViewModels
{
    public class BasketDetailVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
    }
}
