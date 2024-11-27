using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskManagementSystem.Models;


namespace TaskMs.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<TaskItem> TaskItems { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            optionsBuilder.
                UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=TaskDB;Trusted_Connection=True;");
        }
    }
}
