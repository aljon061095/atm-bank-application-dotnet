using System;
using System.ComponentModel.DataAnnotations;

public class WithdrawalModel
{
    [Required]
    public string CardNumber { get; set; }

    [Required]
    public string Password { get; set; }

    [Required]
    public int Amount { get; set; }
}
