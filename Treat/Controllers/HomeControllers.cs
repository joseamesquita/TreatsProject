using Microsoft.AspNetCore.Mvc;

namespace Treat.Controllers
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