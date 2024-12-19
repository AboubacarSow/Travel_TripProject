using System.ComponentModel.DataAnnotations;

namespace Travel_TripProject.Models
{
    public class MainHome
    {
        [Key]
        public int Id { get; set; } 
        public string Title {  get; set; }  
        public string Description { get; set; }

    }
}