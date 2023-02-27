using Microsoft.AspNetCore.Mvc;
using Bakery.Models;

namespace Bakery.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Homepage() { return View(); }


    [Route("/Order")]
    public ActionResult Order(string baguette, string white, string black, string pie, string croissants)
    {
      int sum = Bread.BreadSum(baguette, white, black);
      sum = sum + Pastry.PastrySum(pie, croissants);
      Variable myVariable = new Variable();
      myVariable.Sum = sum;
      myVariable.Baguette = baguette;
      myVariable.White = white;
      myVariable.Black = black;
      myVariable.Pie = pie;
      myVariable.Croissants = croissants;
      return View(myVariable);
    }

  }
}