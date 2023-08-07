using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Entidades
{
    public class Starships : Vehicles
    {
        private const string base_url = "https://swapi.dev/api/starships";

        public new string img_url = "https://starwars-visualguide.com/assets/img/starships";

        public string starship_class { get; set; }

        public string hyperdrive_rating { get; set; }

        public string MGLT { get; set; }
        
        public new Interfaces.SWAPI<Starships> API = new Interfaces.SWAPI<Starships>(base_url);

        public new string getImage()
        {
            var splited = this.url.Split('/');

            int id = int.Parse(splited[splited.Length - 2]);

            bool ver = VerificarExistenciaImagem($"{img_url}/{id}.jpg");

            if (ver)
            {

                return $"{img_url}/{id}.jpg";

            }
            else
            {

                return this.default_img;

            }
        }

    }
}