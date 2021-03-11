using BookManagement.DbContexts;
using BookManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagement.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext context;

        public CategoryService(AppDbContext context)
        {
            this.context = context;
        }
        public List<Category> GetCategories()
        {
            return context.Categories.ToList();
        }
    }
}
