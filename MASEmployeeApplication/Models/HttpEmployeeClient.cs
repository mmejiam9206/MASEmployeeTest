using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace MASEmployeeApplication.Models
{
    public class HttpEmployeeClient
    {
        private HttpClient client = new HttpClient();

        public HttpEmployeeClient()
        {
            client.BaseAddress = new Uri("http://masglobaltestapi.azurewebsites.net");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json")
            );
        }

        public async Task<String> GetEmployees()
        {
            HttpResponseMessage response = await client.GetAsync("/api/Employees");

            Task<string> t = null;

            if (response.IsSuccessStatusCode)
            {
                t = response.Content.ReadAsStringAsync();
            }

            return await t;
        }

    }
}