using Microsoft.AspNetCore.Mvc;

namespace SistemaLocacao.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
