using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Book_MVC.Models;

namespace Book_MVC.Data
{
    public class Book_MVCDatabase : DbContext
    {
        public Book_MVCDatabase (DbContextOptions<Book_MVCDatabase> options)
            : base(options)
        {
        }

        public DbSet<Book_MVC.Models.Authors> Authors { get; set; }

        public DbSet<Book_MVC.Models.Publisher> Publisher { get; set; }

        public DbSet<Book_MVC.Models.Books> Books { get; set; }

        public DbSet<Book_MVC.Models.Publications> Publications { get; set; }
    }
}
