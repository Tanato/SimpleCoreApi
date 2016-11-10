using Microsoft.AspNetCore.Mvc;

namespace Calcular.CoreApi.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return Redirect("/swagger/ui/index.html");
        }
    }
}
