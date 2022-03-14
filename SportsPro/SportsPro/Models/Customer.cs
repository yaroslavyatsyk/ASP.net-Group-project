using System.ComponentModel.DataAnnotations;

namespace SportsPro.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Please enter first name.")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Please enter last name.")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Please enter city.")]
        public string? City { get; set; }

        [Required(ErrorMessage = "Please enter state.")]
        public string? State { get; set; }

        [Required(ErrorMessage = "Please enter postal code.")]
        [DataType(DataType.PostalCode)]
        public string? PostalCode { get; set; }

        [Required(ErrorMessage = "Please enter country.")]
        public string? Country{ get; set; }

        [Required(ErrorMessage = "Please enter email.")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Please enter the phone number.")]
        [DataType(DataType.PhoneNumber,ErrorMessage = "The phone number must be in format (XXX)-XXX-XXXX")]
        public string? Phone { get; set; }

        public string FullName => FirstName?.Replace(' ', '-') + " " + LastName?.Replace(' ', '-');
    }
}
