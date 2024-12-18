using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEnableNetworkLogging
{
    internal class Program
    {        
        private static HttpClient sharedClient = new HttpClient()
        {
            BaseAddress = new Uri("https://www.bing.com"),
        };

        static async Task Main(string[] args)
        {
            var response = await sharedClient.GetAsync("/");
        }


    }
}
