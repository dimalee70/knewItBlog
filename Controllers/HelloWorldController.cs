using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace blog.Controllers
{
    public class HelloWorldController : Controller
    {
                
        // GET: /HelloWorld/

        public string Index()
        {
            return "This is my default action...";
        }
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
        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
    }
}