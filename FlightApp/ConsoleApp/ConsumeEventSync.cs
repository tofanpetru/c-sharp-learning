using System;
using System.Net;
namespace ConsoleApp
{
    public class ConsumeEventSync
    {
        public void GetAllFlights()
        {
            using var client = new WebClient();

            client.Headers.Add("Content-Type:application/json");
            client.Headers.Add("Accept:application/json");
            var result = client.DownloadString("https://localhost:44333/api/Flight");
            Console.WriteLine(Environment.NewLine + result);
        }
    }
}
