using System.Collections.Generic;

namespace PierresBakeryMVC.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> { };
    public string Name { get; set; }
    public string Desc { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }

    public Vendor(string vendorName, string desc)
    {
      Name = vendorName;
      Desc = desc;
      _instances.Add(this);
      Id = _instances.Count - 1;
      Orders = new List<Order> { };
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Vendor Find(int searchId)
    {
      return _instances[searchId];
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
  }

}