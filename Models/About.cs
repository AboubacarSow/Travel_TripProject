using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Travel_TripProject.Models
{
    public class About
    {
        [Key] 
        public int AboutId {  get; set; }    
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}