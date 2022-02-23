using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;

namespace SportsPro.Models
{
    public class Incident
    {
        [Key]
        public int IncidentId { get; set; }

        [Required]
        public string? Title { get; set; }   

        [Required]

        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Please choose customer from dropdown")]
        public Customer? Customer { get; set; }

        public int ProductId { get; set; }

        [Required(ErrorMessage = "Please choose product from dropdown")]
        public Product? Product { get; set; }

        public DateTime DateOpened { get; set; }
        [Required(ErrorMessage = "Please choose date when incident was closed")]
        public DateTime DateClosed { get; set; }

        public int TechnicianId { get; set; }
        public Technician? Technician { get; set; }
        [Required(ErrorMessage = "Please add incident description")]
        public string? Description { get; set; }
     }
}
