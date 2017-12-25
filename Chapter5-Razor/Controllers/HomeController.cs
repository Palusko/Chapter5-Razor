using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Chapter5_Razor.Models;

namespace Chapter5_Razor.Controllers
{
  public class HomeController : Controller
  {
    Product product = new Product
    {
      ProductId = 1,
      Name = "Kayak",
      Description = "A boat for one person",
      Category = "Watersports",
      Price = 275m
    };

    // GET: Home
    public ActionResult Index()
    {
      return View(product);
    }

    public ActionResult NameAndPrice()
    {
      return View(product);
    }

    public ActionResult DemoExpression()
    {
      ViewBag.ProductCount = 1;
      ViewBag.ExpressShip = true;
      ViewBag.ApplyDiscount = false;
      ViewBag.Supplier = null;

      return View(product);
    }

    public ActionResult DemoArray()
    {
      Product[] array =
      {
        new Product {Name = "Kayak",
                     Price = 275m},
        new Product {Name = "LifeJacket",
                     Price = 48.95m},
        new Product {Name = "Soccer ball",
                     Price = 19.50m},
        new Product {Name = "Corner Flag",
                     Price = 34.95m}
      };

      return View(array);
    }
  }
}