using System;
using System.Linq;
using knewItBlog.Models;
using knewItBlog.EmpDataContext;

namespace knewItBlog.Data
{
    public static class DbInitializer
    {
        public static void Initialize(AppDataContext context)
        {
            context.Database.EnsureCreated();
            // Look for any students.

            var user_statuses = new User_Status[]
            {
                new User_Status{ User_status="Admin"},
                new User_Status{User_status="User"}
            };
            foreach(User_Status u_s in user_statuses)
            {
                context.User_Statuses.Add(u_s);
            }
            context.SaveChanges();
            
            var blog_statuses = new Blog_Status[]
            {
                new Blog_Status{blog_status="Accept"},
                new Blog_Status{blog_status="Decline"},
                new Blog_Status{blog_status="Waiting"}
            };
            foreach(Blog_Status b_s in blog_statuses)
            {
                context.Blog_Statuses.Add(b_s);
            }
            context.SaveChanges();

            var users = new User{Name="Dmitriy",Login="dmitriy",Password="1234DimaLi",User_status_id=1};
            context.Users.Add(users);
            context.SaveChanges();
        }
    }
}