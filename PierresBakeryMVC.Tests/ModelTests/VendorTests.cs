using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakeryMVC.Models;
using System.Collections.Generic;
using System;

namespace PierresBakeryMVC.Tests
{
  [TestClass]
  public class VendorTest 
  {

    // public void Dispose()
    // {
    //   Category.ClearAll();
    // }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test category");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
  }
}