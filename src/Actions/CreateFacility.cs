using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class CreateFacility
    {
        public static void CollectInput(Farm farm)
        {
            Console.WriteLine("1. Grazing field");
            Console.WriteLine("2. Chicken house");
            Console.WriteLine("3. Plowed field");
            Console.WriteLine("4. Natural field");
            Console.WriteLine("5. Duck house");

            Console.WriteLine();
            Console.WriteLine("Choose what you want to create");

            Console.Write("> ");
            string input = Console.ReadLine();

            switch (Int32.Parse(input))
            {
                case 1:
                    farm.AddGrazingField(new GrazingField());
                    Console.WriteLine("Grazing field has been added to facilities.");
                    Console.ReadLine();
                    break;
                case 2:
                    farm.AddChickenHouse(new ChickenHouse());
                    Console.WriteLine("Chicken house has been added to facilities.");
                    if (farm.ChickenHomes.Count == 1)
                    {
                        Console.WriteLine($"There is {farm.ChickenHomes.Count} chicken home!");
                    }
                    else
                    {
                        Console.WriteLine($"There are {farm.ChickenHomes.Count} chicken homes!");
                    }
                    Console.ReadLine();
                    break;
                case 3:
                    farm.AddPlowedField(new PlowedField());
                    Console.WriteLine("Plowed field has been added to facilities.");
                    Console.ReadLine();
                    break;
                case 4:
                    farm.AddNaturalField(new NaturalField());
                    Console.WriteLine("Natural field has been added to facilities.");
                    Console.ReadLine();
                    break;
                case 5:
                    farm.AddDuckHouse(new DuckHouse());
                    Console.WriteLine("Duck house has been added to facilities.");
                    if (farm.DuckHomes.Count == 1)
                    {
                        Console.WriteLine($"There is {farm.DuckHomes.Count} duck home!");
                    }
                    else
                    {
                        Console.WriteLine($"There are {farm.DuckHomes.Count} duck homes!");
                    }
                    Console.ReadLine();
                    break;
                default:
                    break;
            }
        }
    }
}