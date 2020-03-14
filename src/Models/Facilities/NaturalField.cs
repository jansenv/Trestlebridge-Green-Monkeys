using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities
{
    public class NaturalField : IFacility<IResource>
    {
        private int _rowCapacity = 10;
        private int _plantPerRowCapacity = 6;
        private Guid _id = Guid.NewGuid();

        private List<IResource> _plants = new List<IResource>();

        public double Capacity
        {
            get
            {
                return _rowCapacity * _plantPerRowCapacity;
            }
        }
        public void AddResource(IResource plant)
        {
            _plants.Add(plant);
            // TODO: implement this...
        }

        public void AddResource(List<IResource> plant)
        {
            // TODO: implement this...
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Natural field {shortId} has {this._plants.Count} plants\n");
            this._plants.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}