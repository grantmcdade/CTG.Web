using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CTG.Web.Models;
using Microsoft.AspNetCore.Authorization;

namespace CTG.Web.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Logout()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
