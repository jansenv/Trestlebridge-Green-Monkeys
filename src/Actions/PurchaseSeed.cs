using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Actions
{
    public class PurchaseSeed
    {
        public static void CollectInput(Farm farm)
        {
            var plantList = new List<IResource>();
            plantList.Add(new Sesame());
            plantList.Add(new Sunflower());
            plantList.Add(new Wildflower());

            foreach (var plant in plantList)
            {
                Console.WriteLine($"{plantList.IndexOf(plant)}. {plant}");
            }

            Console.WriteLine();
            Console.WriteLine("Choose seed to purchase.");

            Console.Write("> ");
            string choice = Console.ReadLine();

            switch (Int32.Parse(choice))
            {
                case 1:
                    ChoosePlowedField.CollectInput(farm, new Sesame());
                    break;
                case 2:
                    ChooseNaturalField.CollectInput(farm, new Sunflower());
                    break;
                case 3:
                    ChooseNaturalField.CollectInput(farm, new Wildflower());
                    break;
                default:
                    break;
            }
        }
    }
}