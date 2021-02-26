using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Connection
{
    public static class GlobalConnection
    {
        public static readonly HttpClient WebApiClient = new HttpClient(new HttpClientHandler { UseDefaultCredentials = true });
        static GlobalConnection()
        {
            WebApiClient.BaseAddress = new Uri("http://localhost:25239/api/");
            WebApiClient.DefaultRequestHeaders.Clear();
            WebApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
