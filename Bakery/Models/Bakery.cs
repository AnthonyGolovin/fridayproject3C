using System.Collections.Generic;

namespace Bakery.Models
{
  public class Vendor
  {
    public string CityName { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    private static List<Vendor> _instances = new List<Vendor> {};

    public Vendor (string cityName, string description)
    {
      CityName = cityName;
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Vendor Find(int searchId)
    {
      return _instances[searchId-1];
    }

  }
}