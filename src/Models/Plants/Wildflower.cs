using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Wildflower : IResource, ISeedProducing
    {
        private int _seedsProduced = 42;
        public string Type { get; } = "Sesame";

        public double Harvest () {
            return _seedsProduced;
        }

        public override string ToString () {
            return $"Wildflower. Bazinga!";
        }
    }
}