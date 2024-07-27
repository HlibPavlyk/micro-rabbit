﻿using System.Runtime.Serialization;

namespace MicroRabbit.Mvc.Models;

public class TransferViewModel
{
    public string Notes { get; set; }
    public int FromAccount { get; set; }
    public int ToAccount { get; set; }
    public decimal TransferAmount { get; set; }
}