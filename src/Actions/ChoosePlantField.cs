using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChoosePlantField
    {
        public static void CollectInput(Farm farm, IResource plant, int fieldTypeNum)
        {
            Utils.Clear();
            Console.WriteLine($"Place the plant where?");
            Console.Write("> ");

            static void NaturalFieldsPrint(Farm farm, IResource plant)
            {
                var filteredFields = farm.NaturalFields.Where(field => field.Capacity > field.PlantCountInt).ToList();
                for (int i = 0; i < filteredFields.Count; i++)
                {
                    Console.Write($"{i + 1}. Natural Field {filteredFields[i].PlantCount()} ");
                    filteredFields[i].PlantTypeCount();
                    Console.WriteLine();
                }
                int choice = Int32.Parse(Console.ReadLine()) - 1;
                filteredFields[choice].AddResource(plant);
            }

            static void PlowedFieldsPrint(Farm farm, IResource plant)
            {
                var filteredFields = farm.PlowedFields.Where(field => field.Capacity > field.PlantCountInt).ToList();
                for (int i = 0; i < filteredFields.Count; i++)
                {
                    Console.Write($"{i + 1}. Plowed Field {filteredFields[i].PlantCount()} ");
                    filteredFields[i].PlantTypeCount();
                    Console.WriteLine();
                }
                int choice = Int32.Parse(Console.ReadLine()) - 1;
                filteredFields[choice].AddResource(plant);
            }

            static void FieldListForSunflowers(Farm farm, IResource plant)
            {
                var filteredNaturalFields = farm.NaturalFields.Where(field => field.Capacity > field.PlantCountInt).ToList();

                var filteredPlowedFields = farm.PlowedFields.Where(field => field.Capacity > field.PlantCountInt).ToList();

                int indexCounter = filteredNaturalFields.Count;

                for (int i = 0; i < filteredNaturalFields.Count; i++)
                {
                    Console.Write($"{i + 1}. Natural Field {filteredNaturalFields[i].PlantCount()} ");
                    filteredNaturalFields[i].PlantTypeCount();
                    Console.WriteLine();
                }

                for (int i = 0; i < filteredPlowedFields.Count; i++)
                {
                    Console.Write($"{i + 1 + indexCounter}. Plowed Field {filteredPlowedFields[i].PlantCount()} ");
                    filteredPlowedFields[i].PlantTypeCount();
                    Console.WriteLine();
                }

                int choice = Int32.Parse(Console.ReadLine()) - 1;

                if (choice > indexCounter - 1)
                {
                    filteredPlowedFields[choice - indexCounter].AddResource(plant);
                }
                else
                {
                    filteredNaturalFields[choice].AddResource(plant);
                }

            }

            if (fieldTypeNum == 1)
            {
                PlowedFieldsPrint(farm, plant);
            }
            else if (fieldTypeNum == 2)
            {
                NaturalFieldsPrint(farm, plant);
            }
            else
            {
                FieldListForSunflowers(farm, plant);
            }

            Console.WriteLine();

            // How can I output the type of Plant chosen here?

            // if (fieldTypeNum == 1)
            // {
            //     farm.PlowedFields[choice].AddResource(Plant);
            // }
            // else if (fieldTypeNum == 2)
            // {
            //     farm.NaturalFields[choice].AddResource(Plant);
            // }
            // else
            // {
            //     if (choice > farm.NaturalFields.Count - 1)
            //     {
            //         choice = choice - farm.NaturalFields.Count;
            //         farm.PlowedFields[choice].AddResource(Plant);
            //     }
            //     else
            //     {
            //         farm.NaturalFields[choice].AddResource(Plant);
            //     }
            // }

            // farm.GrazingFields[choice].AddResource (Plant);

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
            */
            // farm.PurchaseResource<IGrazing>(Plant, choice);
        }
    }
}