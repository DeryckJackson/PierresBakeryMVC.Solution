using Microsoft.AspNetCore.Mvc;

namespace PierresBakeryMVC.Controllers
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