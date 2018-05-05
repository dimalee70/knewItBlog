using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace knewItBlog.Models
{
    public class Blog_Status
    {
        [Key]
        public int Id{get;set;}
        [Required]
        [StringLength(255)]
        public string blog_status{get;set;}

        public ICollection<Blog> Blogs{get;set;}
    }
}