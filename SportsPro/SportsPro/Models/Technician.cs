using System.ComponentModel.DataAnnotations;

namespace SportsPro.Models
{
    public class Technician
    {
        [Key]
        public int TechnicianId { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }

    }
}
