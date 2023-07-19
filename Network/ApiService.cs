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


    }
}
