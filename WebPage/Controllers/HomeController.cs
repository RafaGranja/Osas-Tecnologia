using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using Entidades;
using Models;

namespace WebPage.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            Root root = new Root();
            HomeModel model = new HomeModel();
            model.root = await root.API.call();

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Error()
        {
                
            return View();

        }

    }
}