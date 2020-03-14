using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Wildflower : IResource, ICompostProducing
    {
        private int _seedsProduced = 42;
        private int _compostProduced = 35;
        public string Type { get; } = "Sesame";

        public double Harvest()
        {
            return _seedsProduced;
        }

        public double HarvestCompost()
        {
            return _compostProduced;
        }

        public override string ToString()
        {
            return $"Wildflower. Bazinga!";
        }
    }
}