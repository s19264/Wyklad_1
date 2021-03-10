using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Crawler
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            if (args.Length == 0)
            {
                throw new ArgumentException("nie mam argumentu");
            }

            string url = args[0];

            using (var httpClient = new HttpClient()) { 

            //Crawler
            HttpResponseMessage response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                //Tutaj będzie potrzebny Regex!!!!!!!!!
                Console.WriteLine(content);
            }


            
        }

            Console.WriteLine("Hello World!");
        }
    }
}
