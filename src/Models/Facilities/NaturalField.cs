using System;
using System.Collections.Generic;
using System.Linq;
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
                return _rowCapacity;
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

        public string PlantCount()
        {
            return $"({this._plants.Count} plants)";
        }

        public int PlantCountInt
        {
            get
            {
                return _plants.Count;
            }
        }

        public void PlantTypeCount()
        {
            if (this._plants.Count > 0)
            {
                var PlantTypeCount = this._plants
                    .GroupBy(Plant => Plant.Type)
                    .Select(group =>
                    {
                        return new PlantTypeReport
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

    public class PlantTypeReport
    {
        public string PlantType { get; set; }
        public int PlantCount { get; set; }
    }
}