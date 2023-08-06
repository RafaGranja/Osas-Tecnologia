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

        string url = "https://swapi.dev/api/";

        public async Task<ActionResult> Root()
        {
            Root root = new Root();
            HomeModel model = new HomeModel();
            model.root = await root.API.call();

            return View(model);
        }

        public async Task<ActionResult> Detail(string type, int id)
        {

            if (type == "films")
            {
                DetailModel<Films> detailModel = new DetailModel<Films>(url + type);
                detailModel.root = await detailModel.root.API.call(id);
                return View(detailModel);

            }
            else if (type == "people")
            {
                DetailModel<People> detailModel = new DetailModel<People>(url + type);
                detailModel.root = await detailModel.root.API.call(id);
                return View(detailModel);
            }
            else if (type == "planets")
            {
                DetailModel<Planets> detailModel = new DetailModel<Planets>(url + type);
                detailModel.root = await detailModel.root.API.call(id);
                return View(detailModel);
            }
            else if (type == "species")
            {
                DetailModel<Species> detailModel = new DetailModel<Species>(url + type);
                detailModel.root = await detailModel.root.API.call(id);
                return View(detailModel);
            }
            else if (type == "starships")
            {
                DetailModel<Starships> detailModel = new DetailModel<Starships>(url + type);
                detailModel.root = await detailModel.root.API.call(id);
                return View(detailModel);
            }
            else if (type == "vehicles")
            {
                DetailModel<Vehicles> detailModel = new DetailModel<Vehicles>(url + type);
                detailModel.root = await detailModel.root.API.call(id);
                return View(detailModel);
            }
            else
            {
                DetailModel<Default> detailModel = new DetailModel<Default>(url + type);
                return View(detailModel);
            }

        }

        public ActionResult Erro()
        {

            return View();
        }

    }

}