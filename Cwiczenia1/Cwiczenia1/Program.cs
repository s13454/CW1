using System;
using System.Net.Http;

namespace Cwiczenia1
{
    class Program
    {
        static void Main(string[] args)
        {
            //jakis komentarz
            var client = new HttpClient();
            var result = client.GetAsync("https://www.pja.edu.pl");
            Console.WriteLine("Hello World!");
        }
    }
}
