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
    }
}
