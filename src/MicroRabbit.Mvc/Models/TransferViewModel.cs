using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace MicroRabbit.Mvc.Models;

public class TransferViewModel
{
    [Required]
    public int FromAccount { get; set; }
    
    [Required]
    public int ToAccount { get; set; }
    
    [Required]
    [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than 0")]
    public decimal TransferAmount { get; set; }
}