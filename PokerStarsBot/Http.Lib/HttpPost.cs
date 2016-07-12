using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace Http.Lib
{
    public class HttpPost
    {
        public static string SendJson(String url, String josnStr) {
            using (var client = new HttpClient()) {
                client.BaseAddress = new Uri(url);
                var result = client.PostAsync(url, new StringContent(
                                            josnStr,
                                            Encoding.UTF8,
                                            "application/json")).Result;
                string resultContent = result.Content.ReadAsStringAsync().Result;
                return resultContent;
            }
        }
    }
}
