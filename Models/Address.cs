using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Travel_TripProject.Models
{
    public class Address
    {
        [Key]
        public int AddressId {  get; set; } 
        public string Title { get; set; }
        public string Description {  get; set; }    
        public string PhoneNumber {  get; set; }    

        [EmailAddress]
        public string Email {  get; set; }  
        public string Localisation {  get; set; }
    }
}