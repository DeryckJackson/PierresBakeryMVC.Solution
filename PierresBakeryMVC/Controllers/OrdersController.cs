using Microsoft.AspNetCore.Mvc;
using PierresBakeryMVC.Models;
using System.Collections.Generic;

namespace PierresBakeryMVC.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order order = Order.Find(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", order);
      model.Add("vendor", vendor);
      return View(model);
    }

    [HttpGet("/orders/unfulfilled")]
    public ActionResult Unfulfilled()
    {
      List<Order> unfulfilledOrders = Order.GetUnfulfilledOrders();
      return View(unfulfilledOrders);
    }

    [HttpPost("/orders/fulfilled")]
    public ActionResult Fulfilled(int[] orderIds)
    {
      foreach (int id in orderIds)
      {
        Order.SetFulfilledTrueById(id);
      }
      return Redirect("/Vendors");
    }
  }
}