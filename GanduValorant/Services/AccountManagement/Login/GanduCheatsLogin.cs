using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanduValorant.Services.AccountManagement.Login
{
    public class GanduCheatsLogin : IGanduCheatsLogin
    {

        public async Task<string> Login(string email, string password)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"https://python.internalgandu.repl.co/login/{email}/{password}";
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string content = await response.Content.ReadAsStringAsync();
                        return content;
                    }
                    else
                    {
                        return "-1";
                    }
                }
                catch (HttpRequestException ex)
                {
                    return "-1";
                }
            }
        }
    }
}
