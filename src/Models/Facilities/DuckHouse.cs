using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities
{
  public class DuckHouse : IFacility<IDuckHouse>
  {
    private int _capacity = 12;
    private Guid _id = Guid.NewGuid();

    private List<IDuckHouse> _duck = new List<IDuckHouse>();

    public double Capacity
    {
      get
      {
        return _capacity;
      }
    }

    public void AddResource(IDuckHouse animal)
    {
      // TODO: implement this...
      throw new NotImplementedException();
    }

    public void AddResource(List<IDuckHouse> animals)
    {
      // TODO: implement this...
      throw new NotImplementedException();
    }

    public override string ToString()
    {
      StringBuilder output = new StringBuilder();
      string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

      if (this._duck.Count == 1)
      {
        output.Append($"Duck house {shortId} has {this._duck.Count} duck\n");
      }
      else
      {
        output.Append($"Duck house {shortId} has {this._duck.Count} ducks\n");
      }

      this._duck.ForEach(a => output.Append($"   {a}\n"));

      return output.ToString();
    }
  }
}