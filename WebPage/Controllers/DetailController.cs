using Entidades;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WebPage.Controllers
{
    public class DetailController : Controller
    {

        string url = "https://swapi.dev/api/";

        public Films films = new Films();
        public People people = new People();
        public Planets planets = new Planets();
        public Species species = new Species();
        public Starships starships = new Starships();
        public Vehicles vehicles = new Vehicles();

        public async Task<ActionResult> Films(int id)
        {

            DetailModelFilms detailModel = new DetailModelFilms();
            try
            {
                detailModel.root = await detailModel.root.API.call(id);
                detailModel.characters = await people.API.call(detailModel.root.characters);
                detailModel.planets = await planets.API.call(detailModel.root.planets);
                detailModel.species = await species.API.call(detailModel.root.species);
                detailModel.starships = await starships.API.call(detailModel.root.starships);
                detailModel.vehicles = await vehicles.API.call(detailModel.root.vehicles);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }

            detailModel.root.default_img = detailModel.root.getImage();

            return View(detailModel);

        }

        public async Task<ActionResult> People(int id)
        {

            DetailModelPeople detailModel = new DetailModelPeople();
            try
            {
                detailModel.root = await detailModel.root.API.call(id);
                detailModel.films = await films.API.call(detailModel.root.films);
                detailModel.species = await species.API.call(detailModel.root.species);
                detailModel.starships = await starships.API.call(detailModel.root.starships);
                detailModel.vehicles = await vehicles.API.call(detailModel.root.vehicles);
                detailModel.homeworld = await planets.API.call(detailModel.root.homeworld);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            detailModel.root.default_img = detailModel.root.getImage();
            return View(detailModel);
        }
        public async Task<ActionResult> Planets(int id)
        {
            DetailModelPlanets detailModel = new DetailModelPlanets(url + "planets");
            try
            {
                detailModel.root = await detailModel.root.API.call(id);
                detailModel.films = await films.API.call(detailModel.root.films);
                detailModel.residents = await people.API.call(detailModel.root.residents);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }

            detailModel.root.default_img = detailModel.root.getImage();
            return View(detailModel);
        }
        public async Task<ActionResult> Species(int id)
        {

            DetailModelSpecies detailModel = new DetailModelSpecies();
            try
            {
                detailModel.root = await detailModel.root.API.call(id);
                detailModel.films = await films.API.call(detailModel.root.films);
                detailModel.people = await people.API.call(detailModel.root.people);
                detailModel.homeworld = await planets.API.call(detailModel.root.homeworld);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }

            detailModel.root.default_img = detailModel.root.getImage();
            return View(detailModel);
        }
        public async Task<ActionResult> Starships(int id)
        {

            DetailModelStarships detailModel = new DetailModelStarships();
            try
            {
                detailModel.root = await detailModel.root.API.call(id);
                detailModel.films = await films.API.call(detailModel.root.films);
                detailModel.pilots = await people.API.call(detailModel.root.pilots);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }

            detailModel.root.default_img = detailModel.root.getImage();
            return View(detailModel);
            
        }
        public async Task<ActionResult> Vehicles(int id)
        {

            DetailModelVehicles detailModel = new DetailModelVehicles(url + "vehicles");
            try
            {
                detailModel.root = await detailModel.root.API.call(id);
                detailModel.films = await films.API.call(detailModel.root.films);
                detailModel.pilots = await people.API.call(detailModel.root.pilots);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            detailModel.root.default_img = detailModel.root.getImage();
            return View(detailModel);
            
        }

    }
}
