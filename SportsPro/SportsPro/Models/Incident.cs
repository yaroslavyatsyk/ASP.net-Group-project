using System.ComponentModel.DataAnnotations;

namespace SportsPro.Models
{
    public class Incident
    {
        [Key]
        public int IncidentID { get; set; } 
        [Required]
        public string? Title { get; set; }   

        [Required]

        public int CustomerID { get; set; }

        [Required]
        public Customer? customer { get; set; }

        [Required]
        public int ProductID { get; set; }

        public Product? Product { get; set; }

        public DateTime DateOpened { get; set; }
        public DateTime DateClosed { get; set; }

        [Required]
        public int TechnicianID { get; set; }
        public Technician? Technician { get; set; }

        public string? Description { get; set; }
     }
}
