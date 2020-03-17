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

            while (true)
            {
                try
                {
                    static void NaturalFieldsPrint(Farm farm, IResource plant)
                    {
                        var filteredFields = farm.NaturalFields.Where(field => field.Capacity > field.PlantCountInt).ToList();
                        if (filteredFields.Count() == 0)
                        {
                            Console.WriteLine("No fields are avaliable. Please add a field... Press the return key");
                            Console.ReadLine();
                        }
                        else
                        {

                            for (int i = 0; i < filteredFields.Count; i++)
                            {
                                Console.Write($"{i + 1}. Natural Field {filteredFields[i].PlantCount()} ");
                                filteredFields[i].PlantTypeCount();
                                Console.WriteLine();
                            }
                            int choice = Int32.Parse(Console.ReadLine()) - 1;
                            filteredFields[choice].AddResource(plant);
                        }

                    }

                    static void PlowedFieldsPrint(Farm farm, IResource plant)
                    {
                        var filteredFields = farm.PlowedFields.Where(field => field.Capacity > field.PlantCountInt).ToList();
                        if (filteredFields.Count() == 0)
                        {
                            Console.WriteLine("No fields are avaliable. Please add a field... Press the return key");
                            Console.ReadLine();
                        }
                        else
                        {

                            for (int i = 0; i < filteredFields.Count; i++)
                            {
                                Console.Write($"{i + 1}. Plowed Field {filteredFields[i].PlantCount()} ");
                                filteredFields[i].PlantTypeCount();
                                Console.WriteLine();
                            }
                            int choice = Int32.Parse(Console.ReadLine()) - 1;
                            filteredFields[choice].AddResource(plant);
                        }

                    }

                    static void FieldListForSunflowers(Farm farm, IResource plant)
                    {
                        var filteredNaturalFields = farm.NaturalFields.Where(field => field.Capacity > field.PlantCountInt).ToList();

                        var filteredPlowedFields = farm.PlowedFields.Where(field => field.Capacity > field.PlantCountInt).ToList();

                        int indexCounter = filteredNaturalFields.Count;

                        if (filteredNaturalFields.Count() == 0 && filteredPlowedFields.Count() == 0)
                        {
                            Console.WriteLine("No fields are avaliable. Please add a field... Press the return key");
                            Console.ReadLine();
                        }
                        else
                        {

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

                    }

                    if (fieldTypeNum == 1)
                    {
                        PlowedFieldsPrint(farm, plant);
                        break;
                    }
                    else if (fieldTypeNum == 2)
                    {
                        NaturalFieldsPrint(farm, plant);
                        break;
                    }
                    else
                    {
                        FieldListForSunflowers(farm, plant);
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid selection! Press return key");
                    Console.ReadLine();
                }
            }
        }
    }
}