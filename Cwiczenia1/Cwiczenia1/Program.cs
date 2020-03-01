using System;
using System.Net.Http;

namespace Cwiczenia1
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            //jakis komentarz
            var client = new HttpClient();
            HttpResponseMessage result = await client.GetAsync("https://www.pja.edu.pl");


            if (result.IsSuccessStatusCode)
            {
                string html = await result.Content.ReadAsStringAsync();

            }
            
                
            Console.WriteLine("kONIEC!");
        }
    }
}
