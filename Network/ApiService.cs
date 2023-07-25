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
        //Menu
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
            StringContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync(url,content);
            response.EnsureSuccessStatusCode();
            return response;
        }
        public async Task<HttpResponseMessage> UpdateMenu(string url, string id, string jsonString)
        {
            StringContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PatchAsync(url + "/" + id,content);
            response.EnsureSuccessStatusCode();
            return response;
        }
        public async Task<HttpResponseMessage> DeleteMenu(string url, string id)
        {
            HttpResponseMessage response = await httpClient.DeleteAsync(url + "/" + id);
            response.EnsureSuccessStatusCode();
            return response;
        }

        //Transaksi
        public async Task<string> GetListMenu(string url)
        {
            HttpResponseMessage response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
