using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{
    public class Chicken : IResource, IMeatProducing, IEggProducing
    {

        private Guid _id = Guid.NewGuid();
        private double _meatProduced = 1.7;

        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }
        public double EggQuantity { get; set; } = 7;
        public string Type { get; set; } = "Chicken";

        // Methods
        public void Eggy()
        {
            Console.WriteLine($"Chicken {this._shortId} laid {this.EggQuantity} eggs");
        }

        public double Butcher()
        {
            return _meatProduced;
        }

        public override string ToString()
        {
            return $"Chicken {this._shortId}. Cluck Cluck!";
        }
    }
}