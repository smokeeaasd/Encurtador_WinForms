using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace Encurtador
{
    internal class Encurtador
    {
        public static async Task<string> Encurtar(string AccessToken, string url = "https://github.com/smokeeaasd")
        {
            RestClient client = new RestClient("https://api-ssl.bit.ly/v4");

            RestRequest request = new RestRequest("shorten");

            request.AddHeader("Authorization", $"Bearer {AccessToken}");

            Dictionary<string, string> parametro = new Dictionary<string, string>
            {
                { "long_url", url }
            };

            request.AddJsonBody(parametro);

            RestResponse response = client.Post(request);

            string content = response.Content;

            JObject jOBJ = JObject.Parse(content);

            return await Task<string>.FromResult((string)jOBJ["id"]);
        }
    }
}
