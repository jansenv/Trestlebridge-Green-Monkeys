using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class PurchaseStock
    {
        public static void CollectInput(Farm farm)
        {
            var animalList = new List<IResource>();
            animalList.Add(new Cow());
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
                case 1:
                    ChooseGrazingField.CollectInput(farm, new Cow());
                    break;
                default:
                    break;
            }
        }
    }
}