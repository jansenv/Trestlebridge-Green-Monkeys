using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseGrazingField
    {
        public static void CollectInput(Farm farm, IResource animal)
        {
            Utils.Clear();
            // while (true) {
            // for (int i = 0; i < farm.GrazingFields.Count; i++) {
            //     Console.WriteLine ($"{i + 1}. Grazing Field");
            // }

            // Console.WriteLine ();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the animal where?");

            // Console.Write("> ");
            static void GrazingFieldSelect(Farm farm, IResource animal)
            {
                var filteredFields = farm.GrazingFields.Where(field => field.Capacity > field.AnimalCount).ToList();

                for (int i = 0; i < filteredFields.Count(); i++)
                {
                    Console.Write($"{i + 1}. Grazing Field {filteredFields[i].ShortId} has {filteredFields[i].AnimalCount} animals");
                    filteredFields[i].AnimalTypeCount();
                    Console.WriteLine();
                }

                int choice = Int32.Parse(Console.ReadLine());
                filteredFields[choice - 1].AddResource(animal);
            }

            GrazingFieldSelect(farm, animal);

            // foreach (var field in farm.GrazingFields) {
            //     if (field.Capacity > field.AnimalCount) {
            //         Console.Write ($"{farm.GrazingFields.IndexOf(field)}.{field} ");
            //         field.AnimalTypeCount ();
            //         Console.WriteLine ("");
            //     }
            // }

            // if (farm.GrazingFields[choice].Capacity > farm.GrazingFields[choice].AnimalCount) {
            //     break;
            // } else {
            //     Console.WriteLine ("Sorry that facility is full.  Please select a different facility.");
            // }
            // }

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}