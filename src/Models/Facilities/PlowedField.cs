using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities {
  public class PlowedField : IFacility<ISeedProducing> {
    private int _rowCapacity = 13;
    private int _plantPerRowCapacity = 5;
    private Guid _id = Guid.NewGuid ();

    private List<ISeedProducing> _seeds = new List<ISeedProducing> ();

    public double Capacity {
      get {
        return _rowCapacity * _plantPerRowCapacity;
      }
    }
    public void AddResource (ISeedProducing seed) {
      // TODO: implement this...
      throw new NotImplementedException ();
    }

    public void AddResource (List<ISeedProducing> seed) {
      // TODO: implement this...
      throw new NotImplementedException ();
    }

    public override string ToString () {
      StringBuilder output = new StringBuilder ();
      string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

      output.Append ($"Plowed field {shortId} has {this._seeds.Count} plants\n");
      this._seeds.ForEach (a => output.Append ($"   {a}\n"));

      return output.ToString ();
    }
  }
}