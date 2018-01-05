using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HousesForSale.Services
{
    public class ApiCall
    {
        private string ApiKey;
        private HttpClient client;
        private String ServerAddress = "";
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_ServerAddress"></param>
        /// <param name="ApiKey"></param>
        public ApiCall(String _ServerAddress)
        {
            this.ServerAddress = _ServerAddress;
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
        }

        public async Task<object> Get(String Method)
        {
            try
            {
                var content = new StringContent("", Encoding.UTF8, "application/json");
                var uri = new Uri(Method);
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<object>(data); ;
                }
                else
                {
                    var data = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<object>(data); ;
                }

            }
            catch (Exception ex)
            {
                // Log.WriteLog(": " + ex.Message);
                return ex.Message;

            }
        }

    }
}
