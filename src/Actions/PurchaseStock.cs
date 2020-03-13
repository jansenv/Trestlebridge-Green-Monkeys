using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Actions
{
    public class PurchaseStock
    {
        public static void CollectInput(Farm farm)
        {
            var animalList = new List<IResource>();
            animalList.Add(new Chicken());
            animalList.Add(new Cow());
            animalList.Add(new Duck());
            animalList.Add(new Goat());
            animalList.Add(new Ostrich());
            animalList.Add(new Pig());
            animalList.Add(new Sheep());

            foreach (var animal in animalList)
            {
                Console.WriteLine($"{animalList.IndexOf(animal)}. {animal}");
            }

            Console.WriteLine();
            Console.WriteLine("What are you buying today?");

            Console.Write("> ");
            string choice = Console.ReadLine();

            switch (Int32.Parse(choice))
            {
                case 0:

                    // create chooseChickenHouse
                    ChooseChickenHouse.CollectInput(farm, new Chicken());
                    break;
                case 1:
                    ChooseGrazingField.CollectInput(farm, new Cow());
                    break;
                case 2:
                    // create chooseDuckHouse
                    ChooseDuckHouse.CollectInput(farm, new Duck());
                    break;
                case 3:
                    ChooseGrazingField.CollectInput(farm, new Goat());
                    break;
                case 4:
                    ChooseGrazingField.CollectInput(farm, new Ostrich());
                    break;
                case 5:
                    ChooseGrazingField.CollectInput(farm, new Pig());
                    break;
                case 6:
                    ChooseGrazingField.CollectInput(farm, new Sheep());
                    break;
                default:
                    break;
            }
        }

        public static void CollectPlantInput(Farm farm)
        {
            var plantList = new List<IResource>();
            plantList.Add(new Sesame());

            foreach (var plant in plantList)
            {
                Console.WriteLine($"{plantList.IndexOf(plant)}. {plant}");
            }

            Console.WriteLine();
            Console.WriteLine("What are you buying today?");

            Console.Write("> ");
            string choice = Console.ReadLine();

            switch (Int32.Parse(choice))
            {
                case 1:
                    ChooseGrazingField.CollectInput(farm, new Chicken());
                    break;
                default:
                    break;
            }
        }
    }
}