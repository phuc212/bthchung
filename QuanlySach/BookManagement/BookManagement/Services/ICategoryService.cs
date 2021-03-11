﻿using BookManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagement.Services
{
    public interface ICategoryService
    {
        public List<Category> GetCategories();
    }
}
