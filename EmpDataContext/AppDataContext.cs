using Microsoft.EntityFrameworkCore;
using knewItBlog.Models;

namespace knewItBlog.EmpDataContext
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options):base(options)
        {

        }
        public DbSet<Employee> Employees{get;set;}
        
    }
}