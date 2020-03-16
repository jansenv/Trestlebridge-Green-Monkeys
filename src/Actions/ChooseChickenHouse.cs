using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions {
    public class ChooseChickenHouse {
        public static void CollectInput (Farm farm, IEggProducing animal) {
            Utils.Clear ();

            // for (int i = 0; i < farm.ChickenHomes.Count; i++)
            // {
            //     Console.WriteLine($"{i + 1}. Chicken House");
            // }

            // Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine ($"Place the animal where?");

            static void chickenHouseSelect (Farm farm, IEggProducing animal) {
                var filteredChickenHouses = farm.ChickenHomes.Where (home => home.Capacity > home.AnimalCount).ToList ();

                for (int i = 0; i < filteredChickenHouses.Count (); i++) {
                    Console.Write ($"{i+1}. Chicken House {filteredChickenHouses[i].ShortId} has {filteredChickenHouses[i].AnimalCount} chickens");

                    Console.WriteLine ();
                }

                int choice = Int32.Parse (Console.ReadLine ());
                filteredChickenHouses[choice - 1].AddResource (animal);
            }

            chickenHouseSelect (farm, animal);

            // Console.Write("> ");
            // foreach (var field in farm.ChickenHomes) {
            //     if (field.Capacity > field.AnimalCount) {
            //         Console.WriteLine ($"{farm.ChickenHomes.IndexOf(field)}. {f}");
            //     }
            // }
            // int choice = Int32.Parse (Console.ReadLine ());

            // farm.ChickenHomes[choice].AddResource (animal);

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}