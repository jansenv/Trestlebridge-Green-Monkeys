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
            Console.WriteLine($"Place the animal where?");

            while (true)
            {
                try
                {
                    static void chickenHouseSelect(Farm farm, IEggProducing animal)
                    {
                        var filteredChickenHouses = farm.ChickenHomes.Where(home => home.Capacity > home.AnimalCount).ToList();

                        if (filteredChickenHouses.Count() == 0)
                        {
                            Console.WriteLine("No houses are avaliable. Please add another house...");
                            Console.ReadLine();
                        }
                        else
                        {

                            for (int i = 0; i < filteredChickenHouses.Count(); i++)
                            {
                                Console.Write($"{i+1}. Chicken House {filteredChickenHouses[i].ShortId} has {filteredChickenHouses[i].AnimalCount} chickens");

                                Console.WriteLine();
                            }

                            int choice = Int32.Parse(Console.ReadLine());
                            filteredChickenHouses[choice - 1].AddResource(animal);
                        }

                    }

                    chickenHouseSelect(farm, animal);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine($"Please make a valid selection! Press the return key...");
                    Console.ReadLine();
                }
            }

        }
    }
}