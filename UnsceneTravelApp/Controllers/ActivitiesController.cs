using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UnsceneTravelApp.Controllers
{
    public class ActivitiesController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

    public IActionResult Add()
        {
            return View();
        }
    }
}

