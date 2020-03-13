using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseDuckHouse
    {
        public static void CollectInput(Farm farm, IEggProducing animal)
        {
            Utils.Clear();

            for (int i = 0; i < farm.DuckHomes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Duck House");
            }

            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the animal where?");

            // Console.Write("> ");
            foreach (var home in farm.DuckHomes)
            {
                Console.WriteLine($"{farm.DuckHomes.IndexOf(home)}. {home}");
            }
            int choice = Int32.Parse(Console.ReadLine());

            farm.DuckHomes[choice].AddResource(animal);

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IEggProducing>(animal, choice);

        }
    }
}