using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using cca_p_mvvm.ViewModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace cca_p_mvvm
{
    public class WebServiceClient
    {
        public async Task<List<T>> Get<T>(string url)
        {
            //ALLOWS US TO SEND AND RECIEVE HTTP REQUESTS
            HttpClient client = new HttpClient();
            
            //GET STUFF FROM THE URL
            var response = await client.GetAsync(url);

            //CONVERT PULLED INFORMATION INTO A STRING
            var json = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<List<T>>(json);
        }
    }
}
