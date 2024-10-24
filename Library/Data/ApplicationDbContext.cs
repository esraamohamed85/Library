﻿using Library.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Library.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Checkout> checkouts { get; set; }
        public DbSet<Member> members { get; set; }
        public DbSet<Penalty> penalties { get; set; }
        public DbSet<Return> returns { get; set; }
        public DbSet<SearchHistory> searchHistories { get; set; }

    }
}
