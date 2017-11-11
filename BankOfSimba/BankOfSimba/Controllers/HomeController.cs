using Microsoft.AspNetCore.Mvc;
using BankOfSimba.ViewModels.Home;

namespace BankOfSimba.Controllers
{
    public class HomeController : Controller
    {
        HomeViewModel homeViewModel;

        public HomeController(HomeViewModel homeViewModel)
        {
            this.homeViewModel = homeViewModel;
        }

        [HttpGet]
        [Route("AccountList")]
        public IActionResult Index()
        {
            return View(homeViewModel);
        }

        [HttpPost]
        [Route("AccountList")]
        public IActionResult MyAction()
        {
            homeViewModel.Raise();
            return RedirectToAction("Index");
        }
    }
}