﻿using System.Text.RegularExpressions;

namespace CoffeePointOfSale.Services.DrinkMenu;

public class Customization
{
    public string Name { get; set; }

    public Customization(string name)
    {
        Name = name;
    }

    public decimal Price { get; set; }

    public string Url => Regex.Replace(Name.Trim(), "[^a-zA-Z0-9]", "-");

    public override string ToString()
    {
        return $"{Name}: {Price:C2}";
    }
}
