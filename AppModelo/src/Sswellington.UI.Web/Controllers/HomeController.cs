using Microsoft.AspNetCore.Mvc;

namespace Sswellington.UI.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}