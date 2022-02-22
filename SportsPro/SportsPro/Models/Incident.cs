using System.ComponentModel.DataAnnotations;

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

        [Required]
        public Customer? Customer { get; set; }

        [Required]
        public int ProductId { get; set; }

        public Product? Product { get; set; }

        public DateTime DateOpened { get; set; }
        public DateTime DateClosed { get; set; }

        public int TechnicianId { get; set; }
        public Technician? Technician { get; set; }

        public string? Description { get; set; }
     }
}
