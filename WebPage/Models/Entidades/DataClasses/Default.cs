using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Web;

namespace Entidades
{

    public static class StringExtensions
    {
        public static string FirstCharToUpper(this string input)
        {
            switch (input)
            {
                case null: throw new ArgumentNullException(nameof(input));
                case "": throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input));
                default: return input[0].ToString().ToUpper() + input.Substring(1);
            }
        }
    }

    public class Default
    {

        public string url { get; set; }

        public string created { get; set; }

        public string edited { get; set; }

        public string default_img = "https://t4.ftcdn.net/jpg/04/99/93/31/360_F_499933117_ZAUBfv3P1HEOsZDrnkbNCt4jc3AodArl.jpg";

        public string img_url = "https://t4.ftcdn.net/jpg/04/99/93/31/360_F_499933117_ZAUBfv3P1HEOsZDrnkbNCt4jc3AodArl.jpg";

        public static bool VerificarExistenciaImagem(string imageUrl)
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (var stream = client.OpenRead(imageUrl))
                    {
                        return true; 
                    }
                }
            }
            catch (Exception)
            {
                return false; 
            }
        }

    }
}