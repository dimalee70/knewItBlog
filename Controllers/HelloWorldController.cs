using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using blog.Models;

namespace blog.Controllers
{
    public class HelloWorldController : Controller
    {
                
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
        public ActionResult Person()
        {
            User user = new User(){name = "Dmitriy", surname = "Li",age=25};
            return View(user);
        }
        // public IActionResult Welcome(string name, int numTimes = 1)
        // {
        //     ViewData["Message"] = "Hello " + name;
        //     ViewData["NumTimes"] = numTimes;

        //     return View();
        // }
//         // public IActionResult Index()
//         // {
//         //     return View();
//         // }
//                 // 
        // GET: /HelloWorld/Welcome/ 

        // Requires using System.Text.Encodings.Web;
        // public string Welcome()
        // {
        //     return "This is the Welcome action method...";
        // }
        // public string Welcome(string name, int numTimes = 1)
        // {
        //     return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        // }
    }
}