using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakeryMVC.Models;
using System.Collections.Generic;
using System;

namespace PierresBakeryMVC.Tests
{
  [TestClass]
  public class VendorTest : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test name", "test title");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Test Name";
      Vendor newVendor = new Vendor(name, "test desc");
      string result = newVendor.Name;

      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetDesc_ReturnsDesc_String()
    {
      string desc = "Test Desc";
      Vendor newVendor = new Vendor("name", desc);
      string result = newVendor.Desc;

      Assert.AreEqual(desc, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Test Name";
      string desc = "Test Desc";
      Vendor newVendor = new Vendor(name, desc);

      int result = newVendor.Id;

      Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      Vendor newVendor1 = new Vendor("name", "desc");
      Vendor newVendor2 = new Vendor("name", "desc");
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      Vendor newVendor1 = new Vendor("name", "desc");
      Vendor newVendor2 = new Vendor("name", "desc");

      Vendor result = Vendor.Find(1);

      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_AddsOrderToVendor_Orders()
    {
      Order newOrder = new Order("title", "desc", 5, "date");
    }
  }
}