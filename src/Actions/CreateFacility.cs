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
                    Console.WriteLine($"There is {farm.ChickenHomes.Count} chicken homes!");
                    Console.ReadLine();
                    break;
                default:
                    break;
            }
        }
    }
}