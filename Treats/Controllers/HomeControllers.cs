using Microsoft.AspNetCore.Mvc;

namespace Treats.Controllers
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