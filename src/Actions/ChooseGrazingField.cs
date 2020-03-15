using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions {
    public class ChooseGrazingField {
        public static void CollectInput (Farm farm, IGrazing animal) {
            Utils.Clear ();
            while (true) {
                for (int i = 0; i < farm.GrazingFields.Count; i++) {
                    Console.WriteLine ($"{i + 1}. Grazing Field");
                }

                Console.WriteLine ();

                // How can I output the type of animal chosen here?
                Console.WriteLine ($"Place the animal where?");

                // Console.Write("> ");
                foreach (var field in farm.GrazingFields) {
                    Console.WriteLine ($"{farm.GrazingFields.IndexOf(field)}. {field}");
                }
                int choice = Int32.Parse (Console.ReadLine ());

                if (farm.GrazingFields[choice].Capacity > farm.GrazingFields[choice].AnimalCount) {
                    farm.GrazingFields[choice].AddResource (animal);
                    break;
                } else {
                    Console.WriteLine ("Sorry that facility is full.  Please select a different facility.");
                }
            }

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}