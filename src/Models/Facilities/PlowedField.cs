using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities
{
    public class PlowedField : IFacility<IResource>
    {
        private int _rowCapacity = 13;
        private int _plantPerRowCapacity = 5;
        private Guid _id = Guid.NewGuid();

        private List<IResource> _seeds = new List<IResource>();

        public double Capacity
        {
            get
            {
                return _rowCapacity * _plantPerRowCapacity;
            }
        }
        public void AddResource(IResource plant)
        {
            _seeds.Add(plant);
        }

        public void AddResource(List<IResource> seed)
        {
            // TODO: implement this...
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Plowed field {shortId} has {this._seeds.Count} plants\n");
            this._seeds.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
        public string PlantCount()
        {
            return $"({this._seeds.Count} plants)";
        }
        public void PlantTypeCount()
        {
            if (this._seeds.Count > 0)
            {
                var PlantTypeCount = this._seeds
                    .GroupBy(Plant => Plant.Type)
                    .Select(group =>
                    {
                        return new PlowedTypeReport
                        {
                            PlantType = group.Key,
                            PlantCount = group.Count()
                        };
                    });

                foreach (var report in PlantTypeCount)
                {
                    if (report.PlantCount == 1)
                    {
                        Console.Write($"({report.PlantCount} {report.PlantType}) ");
                    }
                    else
                    {
                        Console.Write($"({report.PlantCount} {report.PlantType}s) ");
                    }
                }
            }
        }
    }
    public class PlowedTypeReport
    {
        public string PlantType { get; set; }
        public int PlantCount { get; set; }
    }
}