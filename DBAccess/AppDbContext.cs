using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;
using Model.Request;

namespace DBAccess
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            if (options is null)
            {
                throw new ArgumentNullException(nameof(options));
            }
        }


        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
    }
}