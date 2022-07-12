using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Http;

namespace DevCard_MVC.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact();
            return View(model);
        }
        //[HttpPost]
        //public JsonResult Contact(IFormCollection form)
        //{
        //    var name = form["name"]; 
        //    return Json(data:Ok());
        //}
        [HttpPost]
        public JsonResult Contact(Contact Form)
        {

            return Json(data: Ok());
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
