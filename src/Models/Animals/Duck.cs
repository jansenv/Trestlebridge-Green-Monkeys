using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{
    public class Duck : IResource, IEggProducing, IMeatProducing
    {

        private Guid _id = Guid.NewGuid();
        private double _meatProduced = .75;

        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public double EggQuantity { get; set; } = 6;
        public string Type { get; } = "Duck";

        // Methods
        public void Eggy()
        {
            Console.WriteLine($"Duck {this._shortId} laid {this.EggQuantity} eggs");
        }

        public double Butcher()
        {
            return _meatProduced;
        }

        public override string ToString()
        {
            return $"Duck {this._shortId}. Quack!";
        }
    }
}