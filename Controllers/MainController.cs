using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace portfoliotwo.Controllers
{
    public class MainController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet("projects")]
        public ViewResult Projects()
        {
            return View();
        }

        [HttpGet("contact")]
        public ViewResult Contact()
        {
            return View();
        }

        [HttpGet("home")]
        public RedirectToActionResult Home()
        {
            return RedirectToAction("Index");
        }
    }
}