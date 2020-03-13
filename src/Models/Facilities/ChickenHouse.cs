using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities
{
  public class ChickenHouse : IFacility<IEggProducing>
  {
    private int _capacity = 15;
    private Guid _id = Guid.NewGuid();

    private List<IEggProducing> _chicken = new List<IEggProducing>();

    public double Capacity
    {
      get
      {
        return _capacity;
      }
    }

    public void AddResource(IEggProducing animal)
    {
      // TODO: implement this...
      throw new NotImplementedException();
    }

    public void AddResource(List<IEggProducing> animals)
    {
      // TODO: implement this...
      throw new NotImplementedException();
    }

    public override string ToString()
    {
      StringBuilder output = new StringBuilder();

      string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

      if (this._chicken.Count == 1)
      {
        output.Append($"Chicken house {shortId} has {this._chicken.Count} chicken\n");
      }
      else
      {
        output.Append($"Chicken house {shortId} has {this._chicken.Count} chicken\n");
      }

      this._chicken.ForEach(a => output.Append($"   {a}\n"));

      return output.ToString();
    }
  }
}