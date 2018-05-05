using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using knewItBlog.Models;

namespace knewItBlog.Models
{
    public class User
    {
        [Key]
        public int Id{get;set;}
        [StringLength(255)]
        public string Name{get;set;}
        [Required]
        [StringLength(100)]
        public string Login{get;set;}
        [Required]
        [StringLength(18, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$)")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        public DateTime DateRegister { get; set;} = DateTime.Now;

        public int User_status_id{get;set;}
        public User_Status User_Statuses{get;set;}
        public ICollection<Blog> Blogs{get;set;}
    }
}