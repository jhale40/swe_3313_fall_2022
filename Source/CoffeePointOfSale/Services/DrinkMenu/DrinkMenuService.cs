using System;
using CoffeePointOfSale.Services.DrinkMenu;
using CoffeePointOfSale.Services.Storage;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System.Reflection;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace CoffeePointOfSale.Services.DrinkMenu;

public class DrinkMenuService : IDrinkMenuService
{
    private readonly IStorageService _storageService;

    public DrinkMenuService(IStorageService storageService)
    {
        _storageService = storageService;
        //your DrinkMenu.json to load on start will go in the JsonStorage directory
        var drinkMenuList  = LoadDrinkMenuFromJsonFile();
        var sortedDrinkMenuList = SortDrinkMenuList(drinkMenuList);
        DrinkMenuList = sortedDrinkMenuList.AsReadOnly();
    }

    public IReadOnlyList<Drink> DrinkMenuList { get; init; }

    private static List<Drink> SortDrinkMenuList(List<Drink> drinkMenuList)
    {
        //sort the drink menu with linq (language integrated query)
        var sortedDrinkMenuList = drinkMenuList.OrderBy(drink => drink.Name).ThenBy(drink => drink.BasePrice).ToList();

        //sort each list of customizations
        foreach (var drink in sortedDrinkMenuList)
            drink.CustomizationList = drink.CustomizationList.OrderBy(customization => customization.Name)
                .ThenBy(customization => customization.Price).ToList();

        return sortedDrinkMenuList;
    }

    private static List<Drink> LoadDrinkMenuFromJsonFile()
    {
        //load the drink list from the Data/DrinkMenu.json file
        var execDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        var jsonPath = Path.Combine(execDir ?? throw new InvalidOperationException(),
            "JsonStorage",
            "DrinkMenu.json");
        var json = File.ReadAllText(jsonPath);
        var drinkMenuList = JsonConvert.DeserializeObject<List<Drink>>(json);
        if (drinkMenuList == null || !drinkMenuList.Any())
            throw new Exception($"Drink Menu JSON not found or empty at {jsonPath}");

        return drinkMenuList;
    }

    /*public List<DrinkModelCsvLine> ConvertToCsvModel()
    {
        throw new NotImplementedException();
    }*/

    /*public List<DrinkModelCsvLine> ConvertToCsvModel()
    {
        throw new NotImplementedException();
    }*/

    /// <summary>
    ///     Converts drink collection into a type tailored for CSV extract of the drink menu
    /// </summary>
    /// <returns></returns>

    /*public List<DrinkModelCsvLine> ConvertToCsvModel()
    {
        return DrinkMenuList.Select(drink => new DrinkModelCsvLine(drink)).ToList();
    }*/



    /*/// <summary>
    ///     Add service to DI container - normally done in an extension method, but this way for simplicity
    /// </summary>
    /// <param name="services"></param>
    public static void ConfigureService(IServiceCollection services)
    {
        services.AddSingleton<IDrinkMenuService, DrinkMenuService>();
    }*/



}