using Microsoft.AspNetCore.Mvc;
using System;

namespace clean_architecture_in_asp_net_core_mvc.Home
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // View = ~/Home/Index.cshtml
            return View();
        }

        public IActionResult Exception()
        {
            // Demonstrates exception handling
            //  View = ~/Shared/Error.cshtml
            //  see Startup.cs
            throw new NotImplementedException();
        }
    }
}
