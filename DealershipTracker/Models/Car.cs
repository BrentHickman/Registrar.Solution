using System.Collections.Generic;
namespace DealershipTracker.Models
{
  public class Car
  {
    public string Brand { get; set; }
    private static List<Car> _instances = new List<Car> { };

    public Car(string brand)
    {
      Brand = brand;
      _instances.Add(this);
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}