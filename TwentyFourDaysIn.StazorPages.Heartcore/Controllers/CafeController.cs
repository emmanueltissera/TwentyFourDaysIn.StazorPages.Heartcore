using Microsoft.AspNetCore.Mvc;
using TwentyFourDaysIn.StazorPages.Heartcore.Models;

namespace TwentyFourDaysIn.StazorPages.Heartcore.Controllers
{
    public class CafeController : Controller
    {
        public IActionResult Index(Cafe model)
        {
            return View(model);
        }
    }
}