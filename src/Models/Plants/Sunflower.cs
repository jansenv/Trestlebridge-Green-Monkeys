using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Sunflower : IResource, ISeedProducing, ICompostProducing
    {
        private int _seedsProduced = 41;
        private int _compostProduced = 39;
        public string Type { get; } = "Sunflower";

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
            return $"Sunflower. T-t-t-t-tasty, tasty!";
        }
    }
}