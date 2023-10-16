using Microsoft.AspNetCore.Mvc;

namespace CrudWeb.Controllers
{
    public class RelatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
