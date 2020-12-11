using System;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models.Users
{
	public class DepositModel
	{
		[Required]
		public string CardNumber { get; set; }

        [Required]
		public string Password { get; set; }

		[Required]
		public int Amount { get; set; }
	}
}
