using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities
{
  public class ChickenHouse : IFacility<IChickenHouse>
  {
    private int _capacity = 25;
    private Guid _id = Guid.NewGuid();

    private List<IChickenHouse> _chicken = new List<IChickenHouse>();

    public double Capacity
    {
      get
      {
        return _capacity;
      }
    }

    public void AddResource(IChickenHouse chicken)
    {
      // TODO: implement this...
      throw new NotImplementedException();
    }

    public void AddResource(List<IChickenHouse> chicken)
    {
      // TODO: implement this...
      throw new NotImplementedException();
    }

    public override string ToString()
    {
      StringBuilder output = new StringBuilder();
      string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

      output.Append($"Chicken house {shortId} has {this._chicken.Count} chickens\n");
      this._chicken.ForEach(a => output.Append($"   {a}\n"));

      return output.ToString();
    }
  }
}