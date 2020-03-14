using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Wildflower : IResource
    {
        public string Type { get; } = "Wildflower";

        public override string ToString()
        {
            return $"Wildflower. Bazinga!";
        }
    }
}