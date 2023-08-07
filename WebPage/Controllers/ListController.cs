using Entidades;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;

namespace Controllers
{

    public class ListController : Controller
    {

        string url = "https://swapi.dev/api/";

        public async Task<ActionResult> Films(int? id)
        {

            ListFilmsModel listModel = new ListFilmsModel(url);

            if (id.HasValue)
            {
                listModel.root = await listModel.root.API.callPage(id.Value);;
            }
            else
            {

                listModel.root = await listModel.root.API.call();
            }


            foreach (Films item in listModel.root.results)
            {

                item.default_img = item.getImage();

            }


            return View(listModel);

        }

        public async Task<ActionResult> People(int? id)
        {

            ListPeopleModel listModel = new ListPeopleModel(url);

            if (id.HasValue)
            {
                listModel.root = await listModel.root.API.callPage(id.Value);;
            }
            else
            {

                listModel.root = await listModel.root.API.call();
            
            }

            foreach(People item in listModel.root.results)
            {

                item.default_img = item.getImage();

            }

            return View(listModel);

        }

        public async Task<ActionResult> Planets(int? id)
        {

            ListPlanetsModel listModel = new ListPlanetsModel(url);
            if (id.HasValue)
            {
                listModel.root = await listModel.root.API.callPage(id.Value);
            }
            else
            {

                listModel.root = await listModel.root.API.call();
            }


            foreach (Planets item in listModel.root.results)
            {

                item.default_img = item.getImage();

            }

            return View(listModel);

        }

        public async Task<ActionResult> Species(int? id)
        {

            ListSpeciesModel listModel = new ListSpeciesModel(url);
            if (id.HasValue)
            {
                listModel.root = await listModel.root.API.callPage(id.Value);;
            }
            else
            {

                listModel.root = await listModel.root.API.call();
            }
            foreach (Species item in listModel.root.results)
            {

                item.default_img = item.getImage();

            }
            return View(listModel);

        }

        public async Task<ActionResult> Starships(int? id)
        {

            ListStarshipsModel listModel = new ListStarshipsModel(url);
            if (id.HasValue)
            {
                listModel.root = await listModel.root.API.callPage(id.Value);;
            }
            else
            {

                listModel.root = await listModel.root.API.call();
            }
            foreach (Starships item in listModel.root.results)
            {

                item.default_img = item.getImage();

            }
            return View(listModel);

        }

        public async Task<ActionResult> Vehicles(int? id)
        {

            ListVehiclesModel listModel = new ListVehiclesModel(url);
            if (id.HasValue)
            {
                listModel.root = await listModel.root.API.callPage(id.Value);;
            }
            else
            {

                listModel.root = await listModel.root.API.call();
            }
            foreach (Vehicles item in listModel.root.results)
            {

                item.default_img = item.getImage();

            }
            return View(listModel);

        }

    }

}