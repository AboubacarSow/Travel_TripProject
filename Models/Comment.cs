using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Travel_TripProject.Models
{
    public class Comment
    {
        [Key]
        public int CommentId {  get; set; } 
        public string UserName {  get; set; }
        [EmailAddress]
        public string UserEmail { get; set; }
        public string CommmentBody {  get; set; }   
        public int BlogId {  get; set; }
        public virtual Blog Blog { get; set; }
    }
}