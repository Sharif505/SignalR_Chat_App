using Microsoft.AspNetCore.Mvc;

namespace Mid_10_Exam.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
