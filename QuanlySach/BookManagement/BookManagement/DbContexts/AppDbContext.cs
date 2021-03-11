using BookManagement.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagement.DbContexts
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {

        }

      public  DbSet<Category> Categories { get; set; }
      public  DbSet<Book> Books { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                 new Category()
                 {
                     CategoryId = 1,
                     Name = "Education"                
                 },
                 new Category()
                 {
                     CategoryId = 2,
                     Name = "Sport"
                 }
                );



            modelBuilder.Entity<Book>().HasData(
                new Book() {
                    BookId = 1,
                    Author = "Le Cong Hoang Phuc",
                    CategoryId = 1,
                    Name = "Cach hoc lap trinh c#",
                    PhotoName = "",
                    Price = 300000,
                    Publisher = "Giao Duc",
                    PublishYear = "2021"                    
                                                   
                },
                   new Book()
                   {
                       BookId = 2,
                       Author = "Tan Ton",
                       CategoryId = 1,
                       Name = "Cach hoc lap trinh Java",
                       PhotoName = "",
                       Price = 900000,
                       Publisher = "Giao Duc",
                       PublishYear = "2021"

                   },
                      new Book()
                      {
                          BookId = 3,
                          Author = "Le Cong Hoang Phuc",
                          CategoryId = 2,
                          Name = "Cach da bong hay",
                          PhotoName = "",
                          Price = 200000,
                          Publisher = "Bao Bong Da",
                          PublishYear = "2021"
                      }


                );

            
        }
    }
}
