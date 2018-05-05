using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace knewItBlog.Models
{
    public class User_Status
    {   
        [Key]
        public int Id{get;set;}
        [Required]
        [StringLength(255)]
        public string User_status{get;set;} 
        public ICollection <User> Users{get;set;} 
    }
}