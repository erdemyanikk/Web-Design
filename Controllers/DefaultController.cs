using Microsoft.AspNetCore.Mvc;

namespace GentekElektronik.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
     
    }
}
