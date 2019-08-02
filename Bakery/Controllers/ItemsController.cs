using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;

namespace Bakery.Controllers
{
  public class BakeryController : Controller
  {

    [HttpGet("/bakery")]
    public ActionResult Index()
    {
      List<Bakery> allBakery = Bakery.GetAll();
      return View(allBakery);
    }

    [HttpGet("/bakery/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/bakery")]
    public ActionResult Create(string city, string description)
    {
      Bakery myBakery = new Bakery(city, description);
      return RedirectToAction("Index");
    }

    [HttpPost("/bakery/delete")]
    public ActionResult DeleteAll()
    {
      Bakery.ClearAll();
      return View();
    }

    [HttpGet("/bakery/{id}")]
    public ActionResult Show(int id)
    {
      Bakery foundBakery = Bakery.Find(id);
      return View(foundBakery);
    }

    [HttpGet("/bakery/newest")]
    public ActionResult Newest()
    {
      return View();
    }
    [HttpGet("/bakery/deeper")]
    public ActionResult DeeperDungeonHole()
    {
      return View();
    }
  }
}