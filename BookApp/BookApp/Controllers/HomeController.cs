using Microsoft.AspNetCore.Mvc;

namespace BookApp.Controllers
{
    public class HomeController: Controller
    {
        public ViewResult Index()
        {
            return View();
        }
        public ViewResult AboutUs()
        {
            return View();
        }
    }
}
