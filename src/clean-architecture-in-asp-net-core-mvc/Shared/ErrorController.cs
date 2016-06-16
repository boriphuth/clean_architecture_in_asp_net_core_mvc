using Microsoft.AspNetCore.Mvc;

namespace clean_architecture_in_asp_net_core_mvc.Shared
{
    public class ErrorController : Controller
    {
        public IActionResult Exception()
        {
            return View("~/Shared/500.cshtml");
        }

        public new IActionResult NotFound()
        {
            return View("~/Shared/404.cshtml");
        }
    }
}
