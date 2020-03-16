using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities {
    public class GrazingField : IFacility<IResource> {
        private int _capacity = 20;
        private Guid _id = Guid.NewGuid ();

        private List<IResource> _animals = new List<IResource> ();

        public int AnimalCount {
            get {
                return _animals.Count;
            }
        }
        public double Capacity {
            get {
                return _capacity;
            }
        }
        public void AddResource (IResource animal) {
            // TODO: implement this...
            _animals.Add (animal);
        }

        public void AddResource (List<IResource> animals) {
            // TODO: implement this...
            // throw new NotImplementedException ();
        }

        public override string ToString () {
            StringBuilder output = new StringBuilder ();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append ($"Grazing field {shortId} has {this._animals.Count} animals \n");
            this._animals.ForEach (a => output.Append ($"   {a}\n"));

            return output.ToString ();
        }

        public void AnimalTypeCount () {
            if (this._animals.Count > 0) {
                var AnimalTypeCount = this._animals
                    .GroupBy (Animal => Animal.Type)
                    .Select (group => {
                        return new AnimalTypeReport {
                        AnimalType = group.Key,
                        AnimalCount = group.Count ()
                        };
                    });

                foreach (var report in AnimalTypeCount) {
                    if (report.AnimalCount == 1) {
                        Console.Write ($"({report.AnimalCount} {report.AnimalType}) ");
                    } else {
                        Console.Write ($"({report.AnimalCount} {report.AnimalType}s) ");
                    }
                }
            }
        }

    }
    public class AnimalTypeReport {
        public string AnimalType { get; set; }
        public int AnimalCount { get; set; }
    }

}