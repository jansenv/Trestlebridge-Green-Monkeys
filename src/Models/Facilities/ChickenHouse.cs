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
    public string ShortId
    {
      get
      {
        return this._id.ToString().Substring(this._id.ToString().Length - 6);
      }
    }

    private List<IEggProducing> _chickens = new List<IEggProducing>();
    public int AnimalCount
    {
      get
      {
        return _chickens.Count;
      }
    }
    public double Capacity
    {
      get
      {
        return _capacity;
      }
    }

    public void AddResource(IEggProducing animal)
    {
      _chickens.Add(animal);
    }

    public void AddResource(List<IEggProducing> animals)
    {

    }

    public override string ToString()
    {
      StringBuilder output = new StringBuilder();

      string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

      if (this._chickens.Count == 1)
      {
        output.Append($"Chicken house {shortId} has {this._chickens.Count} chicken\n");
      }
      else
      {
        output.Append($"Chicken house {shortId} has {this._chickens.Count} chickens\n");
      }

      this._chickens.ForEach(a => output.Append($"   {a}\n"));

      return output.ToString();
    }
  }
}