using System.ComponentModel.DataAnnotations;

namespace SportsPro.Models
{
    public class Technician
    {
        [Key]
        public int TechnicianId { get; set; }

        [Required(ErrorMessage = "Please enter first name.")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Please enter last name.")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Please enter email.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Please enter phone.")]
        public string? Phone { get; set; }

        public string Slug => FirstName?.Replace(' ', '-') + LastName?.Replace(' ', '-');

    }
}
