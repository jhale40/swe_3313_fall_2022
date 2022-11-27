using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeePointOfSale.Services.DrinkMenu;

public class Order
{
    public DateTime TransactionDate { get; set; }

    public decimal Subtotal { get; set; }

    public decimal Tax { get; set; }

    public decimal Total { get; set; }

    public int PointsEarned { get; set; }

    public string? PaymentMethod { get; set; }

    public string? PaymentMethodDetails { get; set; }

    public List<Drink>? DrinkList { get; set; }
}
