using Microsoft.AspNetCore.Mvc;

namespace logintest.Controllers
{
    public class AccessController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
