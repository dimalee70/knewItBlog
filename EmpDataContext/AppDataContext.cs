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
        public DbSet<User> Users{get;set;}
        public DbSet<User_Status> User_Statuses{get;set;}
        public DbSet<Blog> Blogs{get;set;}
        public DbSet<Blog_Status> Blog_Statuses{get;set;}
    }
}