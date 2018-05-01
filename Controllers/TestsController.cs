using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using blog.Models;

namespace blog.Controllers
{
    public class TestsController:Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            TestDBContext context = HttpContext.RequestServices
            .GetService(typeof(blog.Models.TestDBContext)) as TestDBContext; 
            //  = HttpContext.RequestServices.GetServ
            //  ice(typeof(MvcSakilaCore.Models.SakilaContext)) as SakilaContext;
    
        return View(context.GetAllTexts());
        }
    }
}