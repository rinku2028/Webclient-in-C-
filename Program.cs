using System;
using System.Net;


namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //Download HTML Tags from webclient
            WebClient client = new WebClient();
            string store = client.DownloadString("https://www.worldometers.info/coronavirus/");
            Console.WriteLine(store);
            Console.ReadLine();
        }
    }
}
