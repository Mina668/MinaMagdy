using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Task.DataAccessLayer.Models;

namespace Task.DataAccessLayer
{
    internal class TaskDbContext: DbContext
    {
        public DbSet<Employee>Employees { get; set; }
        public TaskDbContext(DbContextOptions<TaskDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=TaskDb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Models.Employee>().ToTable("Employees");
        }
    }
}
