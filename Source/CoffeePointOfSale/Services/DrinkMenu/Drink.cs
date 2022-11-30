using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CoffeePointOfSale.Services.DrinkMenu;

public class Drink
{
    private List<Customization> _customizations;



    /*public Drink(string name, decimal basePrice)
    {
        this.Name = name;
        this.BasePrice = basePrice;
        this.BaseDescription = null;
        this._customizations = new List<Customization>();
       


    }*/


    public Drink(List<Customization> customizations)
    {
        _customizations = customizations;
    }



    public string? Name { get; set; }
    public string? BaseDescription { get; set; }
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
