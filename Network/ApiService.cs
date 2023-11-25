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
        public async Task<HttpResponseMessage> CreateCart(string jsonString, string url)
        {
            StringContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync(url, content);
            response.EnsureSuccessStatusCode();
            return response;
        }
        public async Task<string> GetCart(string url)
        {
            HttpResponseMessage response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<string> GetItemOnCart(string url)
        {
            HttpResponseMessage response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<HttpResponseMessage> DeleteCart(string url)
        {
            HttpResponseMessage response = await httpClient.DeleteAsync(url);
            response.EnsureSuccessStatusCode();
            return response;
        }
        public async Task<HttpResponseMessage> PayBill(string jsonString, string url)
        {
            StringContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync(url, content);
            response.EnsureSuccessStatusCode();
            return response;
        }
        public async Task<string> PayBillTransaction(string jsonString, string url)
        {
            StringContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync(url, content);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<string> SaveBill(string jsonString, string url)
        {
            StringContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync(url, content);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<string> GetMenuDetailByID(string url, string id)
        {
            HttpResponseMessage response = await httpClient.GetAsync(url + "/" + id);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<HttpResponseMessage> UpdateCart(string jsonString, string url)
        {
            StringContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PatchAsync(url, content);
            response.EnsureSuccessStatusCode();
            return response;
        }

        public async Task<string> GetDiscount(string url, string id)
        {
            HttpResponseMessage response = await httpClient.GetAsync(url+id);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<HttpResponseMessage> UseDiscount(string jsonString, string url)
        {
            StringContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync(url, content);
            response.EnsureSuccessStatusCode();
            return response;
        }

        public async Task<string> GetListBill(string url, string id)
        {
            HttpResponseMessage response = await httpClient.GetAsync(url + id);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<string> GetActiveCart(string url)
        {
            HttpResponseMessage response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetTransactionRefund(string url)
        {
            HttpResponseMessage response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> Refund(string jsonString, string url)
        {
            StringContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync(url, content);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync(); ;
        }
        public async Task<HttpResponseMessage> inputPin(string jsonString, string url)
        {
            StringContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync(url, content);
            response.EnsureSuccessStatusCode();
            return response;
        }

        public async Task<string> GetCicilDetail(string url)
        {
            HttpResponseMessage response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<HttpResponseMessage> cicilRefund(string jsonString, string url)
        {
            StringContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync(url, content);
            response.EnsureSuccessStatusCode();
            return response;
        }
        public async Task<string> CetakLaporanShift(string jsonString, string url)
        {
            StringContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync(url, content);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync(); 
        }

        public async Task<string> GetPaymentType(string url)
        {
            HttpResponseMessage response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<HttpResponseMessage> notifikasiPengeluaran(string jsonString, string url)
        {
            StringContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync(url, content);
            response.EnsureSuccessStatusCode();
            return response;
        }

        public async Task<HttpResponseMessage> deleteCart(string jsonString, string url)
        {
            StringContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync(url, content);
            response.EnsureSuccessStatusCode();
            return response;
        }

        public async Task<string> Restruk(string url)
        {
            HttpResponseMessage response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
