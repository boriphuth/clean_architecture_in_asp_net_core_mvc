using Microsoft.AspNetCore.Mvc;

namespace clean_architecture_in_asp_net_core_mvc.Products
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

