using FinalClearance.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using FinalClearance.Models;


namespace FinalClearance.Controllers
{
    public class DashboardController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public DashboardController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
                
        }
        public IActionResult Index()
        {
            ViewData["UserID"] = _userManager.GetUserId(this.User);
            ViewData["userName"] = _userManager.GetUserName(this.User);
            return View();
        }
       
        public IActionResult SimpleTable()
        {
            ViewData["UserID"] = _userManager.GetUserId(this.User);
            ViewData["userName"] = _userManager.GetUserName(this.User);
            return View();
        }
        public IActionResult AcademicDetails(Person person )
        {
            //return RedirectToAction("NextOfKin");
            return View();


        }

        public IActionResult StartClearance(Person person)
        {
            //return RedirectToAction("AcademicDetails");
            return View();
        }

       
        public IActionResult NextOfKin(Person person)
        {
            //return RedirectToAction("StartClearance");
            return View();

        }



    }
}
