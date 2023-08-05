using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace Interfaces
{
    public class SWAPI<T>
    {
        private string base_url {get;set;}

        public SWAPI(string base_url)
        {
                
            this.base_url = base_url;

        }

        public async Task<T> call(int id)
        {

            HttpClient http = new HttpClient();

            var response = await http.GetAsync($"{this.base_url}/{id}");

            var json = await response.Content.ReadAsStringAsync();

            var ret = JsonConvert.DeserializeObject<T>(json);

            return ret;

        }

        public async Task<T> call()
        {

            HttpClient http = new HttpClient();

            var response = await http.GetAsync($"{this.base_url}");

            var json = await response.Content.ReadAsStringAsync();

            var ret = JsonConvert.DeserializeObject<T>(json);

            return ret;

        }

        public async Task<List<T>> call(int[] id)
        {

            List<T> ret = new List<T>();

            for(int i = 0; i < id.Length; i++)
            {

                HttpClient http = new HttpClient();

                var response = await http.GetAsync($"{this.base_url}/{id[i]}");

                var json = await response.Content.ReadAsStringAsync();

                ret.Add(JsonConvert.DeserializeObject<T>(json));

            }

            return ret;

        }

        public async Task<List<T>> call(string[] url)
        {

            List<T> ret = new List<T>();

            for (int i = 0; i < url.Length; i++)
            {

                HttpClient http = new HttpClient();

                var response = await http.GetAsync($"{url[i]}");

                var json = await response.Content.ReadAsStringAsync();

                ret.Add(JsonConvert.DeserializeObject<T>(json));

            }

            return ret;

        }

    }
}

