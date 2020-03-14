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
        public List<NaturalField> NaturalFields { get; } = new List<NaturalField>();
        public List<PlowedField> PlowedFields { get; } = new List<PlowedField>();
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
                    ChickenHomes[index].AddResource((IEggProducing)resource);
                    break;
                case "Wildflower":
                    NaturalFields[index].AddResource((ISeedProducing)resource);
                    break;
                case "Sunflower":
                    NaturalFields[index].AddResource((ISeedProducing)resource);
                    break;
                case "Duck":
                    DuckHomes[index].AddResource((IEggProducing)resource);
                    break;
                default:
                    break;
            }
        }

        public void AddGrazingField(GrazingField field)
        {
            GrazingFields.Add(field);
        }
        public void AddNaturalField(NaturalField field)
        {
            NaturalFields.Add(field);
        }
        public void AddPlowedField(PlowedField field)
        {
            PlowedFields.Add(field);
        }

        public void AddChickenHouse(ChickenHouse coup)
        {
            ChickenHomes.Add(coup);
        }
        public void AddDuckHouse(DuckHouse pond)
        {
            DuckHomes.Add(pond);
        }

        public override string ToString()
        {
            StringBuilder report = new StringBuilder();

            GrazingFields.ForEach(gf => report.Append(gf));
            ChickenHomes.ForEach(cc => report.Append(cc));
            DuckHomes.ForEach(dp => report.Append(dp));
            NaturalFields.ForEach(nf => report.Append(nf));
            PlowedFields.ForEach(pf => report.Append(pf));

            return report.ToString();
        }
    }
}