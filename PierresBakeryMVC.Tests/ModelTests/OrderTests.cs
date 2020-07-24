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
    

    
  }
}