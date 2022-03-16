using System.ComponentModel.DataAnnotations;

namespace SportsPro.Models
{
    public class Registration
    {
        [Key]
        public int RegistrationId { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
