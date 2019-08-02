using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;

namespace Bakery.Controllers
{
  public class ItemsController : Controller
  {

    [HttpGet("/bakerypages")]
    public ActionResult Index()
    {
      List<Vendor> allVendor = Vendor.GetAll();
      return View(allVendor);
    }

    [HttpGet("/bakerypages/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/bakerypages")]
    public ActionResult Create(string city, string description)
    {
      Vendor myVendor = new Vendor(city, description);
      return RedirectToAction("Index");
    }

    [HttpPost("/bakerypages/delete")]
    public ActionResult DeleteAll()
    {
      Vendor.ClearAll();
      return View();
    }

    [HttpGet("/bakerypages/{id}")]
    public ActionResult Show(int id)
    {
      Vendor foundVendor = Vendor.Find(id);
      return View(foundVendor);
    }

    [HttpGet("/bakerypages/newest")]
    public ActionResult Newest()
    {
      return View();
    }
    [HttpGet("/bakerypages/deeper")]
    public ActionResult DeeperDungeonHole()
    {
      return View();
    }
  }
}