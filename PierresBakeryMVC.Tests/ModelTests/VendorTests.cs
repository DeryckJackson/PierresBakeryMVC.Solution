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

    public void GetName_ReturnsName_String()
    {
      string name = "Test Name";
      Vendor newVendor = new Vendor(name, "test title");
      string result = newVendor.Name;

      Assert.AreEqual(name, result);
    }

    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Test Name";
      string desc = "Test Desc";
      Vendor newVendor = new Vendor(name, desc);

      int result = newVendor.Id;

      Assert.AreEqual(1, result);
    }
  }
}