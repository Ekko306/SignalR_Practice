using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }

        // GET: /HelloWorld/Welcome/
        public IActionResult Welcome(string name, int numTimes = 1, int ID = 1)
        {
            //return "This is the Welcome action method...";
            //return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}, ID is: {ID}");  // 防止恶意输入
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
