using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Travel_TripProject.Models
{
    public class Admin
    {
        [Key] 
        public int AdminId {  get; set; }
        public string UserName {  get; set; }
        public string Sifre { get; set; }

    }
}