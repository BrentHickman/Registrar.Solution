using RegistrarTracker.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace RegistrarTracker.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}