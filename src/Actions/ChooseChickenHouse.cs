using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseChickenHouse
    {
        public static void CollectInput(Farm farm, IEggProducing animal)
        {
            Utils.Clear();

            for (int i = 0; i < farm.ChickenHomes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Chicken House");
            }

            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the animal where?");

            // Console.Write("> ");
            foreach (var field in farm.ChickenHomes)
            {
                Console.WriteLine($"{farm.ChickenHomes.IndexOf(field)}. {field}");
            }
            int choice = Int32.Parse(Console.ReadLine());

            farm.ChickenHomes[choice].AddResource(animal);

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}