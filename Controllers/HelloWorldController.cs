using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }

        // URL format: /[Controller]/[ActionName]/[Parameters]
        // GET: /HelloWorld/Welcome
        public IActionResult Welcome(string name, int numTimes=1)
        {
            ViewData["message"] = "Hello, " + name;
            ViewData["numTimes"] = numTimes;
            return View();
        }

    }
}
