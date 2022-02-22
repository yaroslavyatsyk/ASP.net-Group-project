using System;
using System.ComponentModel.DataAnnotations;

namespace SportsPro.Models
{
	public class Product
	{
		[Key]
		public int ProductId { get; set; }

		[Required]
		public string? ProductCode { get; set; }

		[Required]
		public string? Name { get; set; }

		public DateTime ReleaseDate { get; set; }
		

	}
}

