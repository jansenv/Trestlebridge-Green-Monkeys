using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions {
    public class ChooseGrazingField {
        public static void CollectInput (Farm farm, IResource animal) {
            Utils.Clear ();

            Console.WriteLine ($"Place the animal where?");

            static void GrazingFieldSelect (Farm farm, IResource animal) {
                var filteredFields = farm.GrazingFields.Where (field => field.Capacity > field.AnimalCount).ToList ();

                for (int i = 0; i < filteredFields.Count (); i++) {
                    Console.Write ($"{i + 1}. Grazing Field {filteredFields[i].ShortId} has {filteredFields[i].AnimalCount} animals");
                    filteredFields[i].AnimalTypeCount ();
                    Console.WriteLine ();
                }

                int choice = Int32.Parse (Console.ReadLine ());
                filteredFields[choice - 1].AddResource (animal);
            }

            GrazingFieldSelect (farm, animal);

        }
    }
}