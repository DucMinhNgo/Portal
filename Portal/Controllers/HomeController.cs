using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
namespace AdminPanelTutorial
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //ViewBag.IsAdmin=false;
            ViewBag.Dashboard=false;
            
            return View();
        }
        public ActionResult Login(){
            return RedirectToAction("Index", "Home");
        } 
    }
}