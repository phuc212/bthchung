using BookManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagement.Services
{
    public interface IBookService
    {
        public Book GetBook(int id);

        public IEnumerable<Book> GetAllBook();
        public Book Add(Book book);
        public bool Delete(int id);
        public Book Update(Book bookChange);

    }
}
