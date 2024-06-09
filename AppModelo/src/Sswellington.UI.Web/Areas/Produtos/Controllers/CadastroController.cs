using Microsoft.AspNetCore.Mvc;

namespace Sswellington.UI.Web.Areas.Produtos.Controllers
{
    [Area("Produtos")]
    public class CadastroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
