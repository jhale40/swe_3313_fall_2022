using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeePointOfSale.Services.DrinkMenu;

public class Drink
{
    private List<Customization> _customizations;
    public string Name { get; set; }
    public string BaseDescription { get; set; }
    public decimal BasePrice { get; set; }
    
    public List<Customization> CustomizationList
    {
        get => _customizations;
        set => _customizations = value ?? new List<Customization>();
    }

    public override string ToString()
    {
        return $"{Name}: {BasePrice:C2} ";
    }


}
