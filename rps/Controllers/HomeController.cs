using Microsoft.AspNetCore.Mvc;
using System;
using RpsGame.Models;

namespace RpsGame.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    [HttpPost("/Resultpvp")]
    public ActionResult Result()
    {

        Console.WriteLine("Show result for PVP");
        string p1 = Request.Form["p1"].ToString();
        string p2 = Request.Form["p2"].ToString();
        Rps newRps = new Rps(p1,p2);

        return View(newRps);
    }
      [HttpPost("/Resultpvc")]
      public ActionResult ResultPvc()
      {
        Console.WriteLine("Show result for PVC");
        Rps newRps = new Rps();
        newRps.SetP1Choice(Request.Form["p1"].ToString());
        newRps.SetP2Choice(newRps.GetComputerChoice());

        return View("Result",newRps);
      }

    }
  }
