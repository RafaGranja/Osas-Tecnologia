using Microsoft.Ajax.Utilities;
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

        private HttpClient http;
        

        public SWAPI(string base_url)
        {
                
            this.base_url = base_url;

            this.http = new HttpClient();

            this.http.Timeout= TimeSpan.FromSeconds(120);

            Console.WriteLine("Url da lista é:"+this.base_url);


        }

        public async Task<T> call(int id)
        {
            string url = this.base_url + "/" + id;

            var response = await http.GetAsync(url);

            var json = await response.Content.ReadAsStringAsync();

            T ret = JsonConvert.DeserializeObject<T>(json);

            return ret;

        }

        public async Task<T> callPage(int id)
        {
            string url = this.base_url + "/?page=" + id;

            var response = await http.GetAsync(url);

            var json = await response.Content.ReadAsStringAsync();

            T ret = JsonConvert.DeserializeObject<T>(json);

            return ret;

        }

        public async Task<T> call()
        {

            var response = await http.GetAsync(this.base_url);

            var json = await response.Content.ReadAsStringAsync();

            T ret = JsonConvert.DeserializeObject<T>(json);

            return ret;

        }

        public async Task<T> call(string url)
        {

            var response = await http.GetAsync(url);

            var json = await response.Content.ReadAsStringAsync();

            T ret = JsonConvert.DeserializeObject<T>(json);

            return ret;

        }

        public async Task<List<T>> call(int[] id)
        {

            List<T> ret = new List<T>();

            for(int i = 0; i < id.Length; i++)
            {
                string url = this.base_url + "/" + id[i];

                var response = await http.GetAsync(url);

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

                var response = await http.GetAsync(url[i]);

                var json = await response.Content.ReadAsStringAsync();

                ret.Add(JsonConvert.DeserializeObject<T>(json));

            }

            return ret;

        }

    }
}

