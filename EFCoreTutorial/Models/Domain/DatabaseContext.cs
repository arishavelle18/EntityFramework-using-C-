﻿using Microsoft.EntityFrameworkCore;

namespace EFCoreTutorial.Models.Domain
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> opts) : base(opts)
        { 
        
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Student>()
                .HasOne(a => a.StudentAddress)
                .WithOne(a => a.Student)
                .HasForeignKey<StudentAddress>(a => a.StudentId);

            builder.Entity<BookGenre>()
                .HasKey(a => new {a.BookId,a.GenreId});
            builder.Entity<BookGenre>()
                .HasOne(a => a.Book)
                .WithMany(a => a.Genres)
                .HasForeignKey(a => a.BookId);
            builder.Entity<BookGenre>()
                .HasOne(a => a.Genre)
                .WithMany(a => a.Books)
                .HasForeignKey(a => a.GenreId);

        }

        public DbSet<Category> Category { get; set; }

        public DbSet<Product> Product { get; set; }

        public DbSet<Student> Student { get; set; }
        public DbSet<StudentAddress> StudentAddress { get; set; }

        public DbSet<Book> Book { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<BookGenre> BookGenre { get; set; }

    }
}
