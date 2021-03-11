using BookManagement.DbContexts;
using BookManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagement.Services
{
    public class SqlBookRepository : IBookService
    {
        private AppDbContext context;
        public SqlBookRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Book Add(Book book)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetAllBook()
        {
           return context.Books;
        }

        public Book GetBook(int id)
        {
            throw new NotImplementedException();
        }

        public Book Update(Book bookChange)
        {
            throw new NotImplementedException();
        }
    }
}
