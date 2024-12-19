using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Travel_TripProject.Models
{
    public class Contact
    {
        [Key]
        public int ContactId {  get; set; } 
        public string FullName { get; set; } 
        public string Subject { get; set; } 
        [EmailAddress]
        public string EMail { get; set; }   
        public string MessageBody { get; set; } 
    }
}