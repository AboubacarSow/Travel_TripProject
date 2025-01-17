﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Travel_TripProject.Models
{
    public class Blog
    {
        [Key] 
        public int BlogId { get; set; } 
        public string Title { get;set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string ImageUrl { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }
     
    }
}