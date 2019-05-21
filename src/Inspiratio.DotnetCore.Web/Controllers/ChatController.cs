using Microsoft.AspNetCore.Mvc;

namespace Inspiratio.DotnetCore.Web.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}