using System.Collections.Generic;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Interfaces
{
  public interface IChickenHouse<T>
  {
    double Capacity { get; }

    void AddResource(T resource);
    void AddResource(List<T> resources);
  }
}