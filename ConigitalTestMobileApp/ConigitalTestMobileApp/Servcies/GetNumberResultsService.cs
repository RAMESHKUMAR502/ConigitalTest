using ConigitalTestMobileApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConigitalTestMobileApp.Servcies
{
    class HttpRequRes
    {
        static HttpClient client = new HttpClient();

        public static async Task RunAsync()
        {

            client.BaseAddress = new Uri(config.BaseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }
        /// <summary>
        /// Sending Request to fetch the Number
        /// </summary>
        /// <param name="anumber"></param>
        /// <returns></returns>
        public static async Task<ResponseModelDTO> GetMultitleNumResults(int anumber)
        {
            ResponseModelDTO ResponseModelDTO = null;
            try
            {

                HttpResponseMessage response = await client.GetAsync($"api/MultiplyNum/{anumber}");
                response.EnsureSuccessStatusCode();

                var res = await response.Content.ReadAsStringAsync();

                if (res != null)
                {
                    ResponseModelDTO = JsonConvert.DeserializeObject<ResponseModelDTO>(res);
                }



                return ResponseModelDTO;
            }
            catch (Exception ex)
            {
                return ResponseModelDTO;
            }
        }

    }
}
