using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KASIR.Network
{
    public interface IApiService
    {
        Task<string> Get(string url);
        Task<string> GetMenuByID(string url, string id);
        Task<HttpResponseMessage> PostAddMenu(string jsonString, string url);
        Task<HttpResponseMessage> UpdateMenu(string url, string id, string jsonString);
        Task<HttpResponseMessage> DeleteMenu(string url, string id);

        Task<string> GetListMenu(string url);
    }
}
