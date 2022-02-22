using System.ComponentModel.DataAnnotations;

namespace SportsPro.Models
{
    public class Technician
    {
        [Key]
        public int TechnicianId { get; set; }

        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? Email { get; set; }

        [Required]
        public string? Phone { get; set; }

        [Required]
        public string? LastName { get; set; }

        public string Slug => FirstName?.Replace(' ', '-') + LastName?.Replace(' ', '-');

    }
}
