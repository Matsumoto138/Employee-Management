using EmployeeHomework.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeHomework.Data
{
    public class EmployeeHomeworkDbContext : DbContext
    {
        public EmployeeHomeworkDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
