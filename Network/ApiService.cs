using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace KASIR.Network
{
    public class ApiService : IApiService
    {
        private readonly HttpClient httpClient;
            private readonly string baseAddress;
        public ApiService()
        {
            baseAddress = Properties.Settings.Default.BaseAddress;
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(baseAddress); // Replace with your API base URL
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<string> Get(string url)
        {
            HttpResponseMessage response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<string> GetMenuByID(string url,string id)
        {
            HttpResponseMessage response = await httpClient.GetAsync(url+"/"+id);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<HttpResponseMessage> PostAddMenu(string jsonString, string url)
        {

            try
            {
                // Set the request content to the JSON string
                StringContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");

                // Send the POST request with the JSON string as the raw JSON body
                HttpResponseMessage response = await httpClient.PostAsync(url, content);

                return response;
            }
            catch (Exception ex)
            {
                // Handle any exception that might occur during the request
                Console.WriteLine("An error occurred: " + ex.Message);
                return null;
            }
        }
    }
}
