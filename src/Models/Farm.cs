using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models
{
    public class Farm
    {
        public List<GrazingField> GrazingFields { get; } = new List<GrazingField>();
        public List<ChickenHouse> ChickenHomes { get; } = new List<ChickenHouse>();
        public List<DuckHouse> DuckHomes { get; } = new List<DuckHouse>();

        /*
            This method must specify the correct product interface of the
            resource being purchased.
         */
        public void PurchaseResource<T>(IResource resource, int index)
        {
            Console.WriteLine(typeof(T).ToString());
            switch (typeof(T).ToString())
            {
                case "Cow":
                    GrazingFields[index].AddResource((IGrazing)resource);
                    break;

                case "Chicken":
                    ChickenHomes[index].AddResource((IChickenHouse)resource);
                    break;
                case "Duck":
                    DuckHomes[index].AddResource((IDuckHouse)resource);
                    break;
                default:
                    break;
            }
        }

        public void AddGrazingField(GrazingField field)
        {
            GrazingFields.Add(field);
        }
        public void AddChickenHouse(ChickenHouse chickenHome)
        {
            ChickenHomes.Add(chickenHome);
        }
        public void AddDuckHouse(DuckHouse duckHome)
        {
            DuckHomes.Add(duckHome);
        }

        public override string ToString()
        {
            StringBuilder report = new StringBuilder();

            GrazingFields.ForEach(gf => report.Append(gf));
            ChickenHomes.ForEach(ch => report.Append(ch));
            DuckHomes.ForEach(dh => report.Append(dh));

            return report.ToString();
        }
    }
}