using Microsoft.AspNetCore.Mvc;

namespace Mid_10_Exam.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View("Chat");
        }
    }
}
