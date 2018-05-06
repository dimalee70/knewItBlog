using System;
using System.ComponentModel.DataAnnotations;

namespace knewItBlog.Models
{
    public class Blog
    {
        [Key]
        public int Id{get;set;}
        [StringLength(100)]
        public string Title{get;set;}
        [StringLength(100000)]
        public string Text{get;set;}
        public DateTime DateWriting { get; set;} = DateTime.Now;

        public int User_Id{get;set;}
        public int Blog_Status_Id{get;set;}

        // public User Users{get;set;}
        // public Blog_Status Blog_Statuses{get;set;}

    
    }
}