using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresBakeryMVC.Models;
using System;

namespace PierresBakeryMVC.Tests
{
  [TestClass]
  public class OrderTest : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesOrderObject_Order()
    {
      Order newOrder = new Order("title", "desc", 5, "date");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string title = "Test Title";
      Order newOrder = new Order(title, "desc", 5, "date");
      string result = newOrder.Title;

      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Int()
    {
      int price = 5;
      Order newOrder = new Order("title", "desc", price, "date");
      int result = newOrder.Price;

      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void GetDate_ReturnsDate_String()
    {
      string date = "7/24/2020";
      Order newOrder = new Order("title", "desc", 5, date);
      string result = newOrder.Date;

      Assert.AreEqual(date, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      Order newOrder = new Order("title", "desc", 5, "date");

      int result = newOrder.Id;

      Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      Order newOrder1 = new Order("title", "desc", 5, "date");
      Order newOrder2 = new Order("title", "desc", 5, "date");
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      Order newOrder1 = new Order("title1", "desc1", 5, "date");
      Order newOrder2 = new Order("title", "desc", 5, "date");

      Order result = Order.Find(1);

      Assert.AreEqual(newOrder2, result);
    }
  }
}