using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo.Infrastructure.Persistence.Entities
{
    internal class ToDoAppDbContext : DbContext
    {
        public ToDoAppDbContext(DbContextOptions<ToDoAppDbContext> options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
    }
}
