using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using Entidades;
using Models;

namespace Controllers
{
    public class HomeController : Controller
    {

        public async Task<ActionResult> Root()
        {
            Root root = new Root();
            HomeModel model = new HomeModel
            {
                root = await root.API.call()
            };

            return View(model);
        }

        public ActionResult Erro()
        {

            return View();
        }

    }

}