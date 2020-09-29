using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Books.APIv2.Entities;
using Microsoft.EntityFrameworkCore;

namespace Books.APIv2.Contexts
{
    public class BooksContext : DbContext
    {
        public DbSet<Book> Books { get; set; }


        public BooksContext(DbContextOptions<BooksContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Author>().HasData(
                new Author()
                {
                    Id = Guid.Parse("f61f34e0-20bd-4692-b4d6-7a0fa4f46183"),
                    FirstName = "George",
                    LastName = "RR Martin"
                },
                new Author()
                {
                    Id = Guid.Parse("bf27ab3a-bb4a-4513-8301-e862c29faef6"),
                    FirstName = "Sergio",
                    LastName = "H Vargas"
                },
                new Author()
                {
                    Id = Guid.Parse("de45057f-0c0d-495f-a807-e3a82d8a96e9"),
                    FirstName = "Testing",
                    LastName = "Contact"
                });


            modelBuilder.Entity<Book>().HasData(
                new Book()
                {
                    Id = Guid.Parse("70066ebf-e890-4078-bf2b-2ce7f57f912b"),
                    AuthorId = Guid.Parse("f61f34e0-20bd-4692-b4d6-7a0fa4f46183"),
                    Title = "First Book",
                    Description = "RR First Book"
                },
                new Book()
                {
                    Id = Guid.Parse("e6567a82-4a04-40e0-b73b-6a172a64b33d"),
                    AuthorId = Guid.Parse("bf27ab3a-bb4a-4513-8301-e862c29faef6"),
                    Title = "Second Book",
                    Description = "Description Second Book"
                },
                new Book()
                {
                    Id = Guid.Parse("f842c828-aa39-42a5-b40a-e95afb722f7b"),
                    AuthorId = Guid.Parse("de45057f-0c0d-495f-a807-e3a82d8a96e9"),
                    Title = "Third Book",
                    Description = "Description Third Book"
                });
            base.OnModelCreating(modelBuilder);
        }
    }
}
