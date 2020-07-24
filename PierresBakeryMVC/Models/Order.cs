using System.Collections.Generic;

namespace PierresBakeryMVC.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Desc { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }
    public bool Fulfilled { get; set; }
    public int Id { get; }
    public static List<Order> _instances = new List<Order>();

    public Order (string title, string desc, int price, string date)
    {
      Title = title;
      Desc = desc;
      Price = price;
      Date = date;
      Fulfilled = false;
      _instances.Add(this);
      Id = _instances.Count - 1;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static Order Find(int id)
    {
      return _instances[id];
    }

    public static List<Order> GetUnfulfilledOrders()
    {
      List<Order> outputList = new List<Order>();
      foreach (Order order in _instances)
      {
        if (!order.Fulfilled)
        {
          outputList.Add(order);
        }
      }
      return outputList;
    }

    public static void SetFulfilledTrueById(int id)
    {
      _instances[id].Fulfilled = true;
    }
  }
}