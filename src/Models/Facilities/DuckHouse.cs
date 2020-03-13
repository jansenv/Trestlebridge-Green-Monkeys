using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities {
  public class DuckHouse : IFacility<IEggProducing> {
    private int _capacity = 12;
    private Guid _id = Guid.NewGuid ();

    private List<IEggProducing> _ducks = new List<IEggProducing> ();

    public double Capacity {
      get {
        return _capacity;
      }
    }

    public void AddResource (IEggProducing animal) {
      _ducks.Add (animal);
      // TODO: implement this...
      // throw new NotImplementedException();
    }

    public void AddResource (List<IEggProducing> animals) {
      // TODO: implement this...
      // throw new NotImplementedException();
    }

    public override string ToString () {
      StringBuilder output = new StringBuilder ();
      string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

      if (this._ducks.Count == 1) {
        output.Append ($"Duck house {shortId} has {this._ducks.Count} duck\n");
      } else {
        output.Append ($"Duck house {shortId} has {this._ducks.Count} _ducks\n");
      }

      this._ducks.ForEach (a => output.Append ($"   {a}\n"));

      return output.ToString ();
    }
  }
}