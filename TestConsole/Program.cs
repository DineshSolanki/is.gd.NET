using System;
using Url = @is.gd.Url;

namespace TestConsole
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
           var shortenedUrl = Url.GetShortenedUrl(
                "www.example.com", v:true).Result;
            Console.WriteLine("Shortened Url: " + shortenedUrl);
            var fullUrl = Url.LookupShortenedUrl(shortenedUrl, true).Result;
            Console.WriteLine("Full Url: " + fullUrl);
            Console.ReadLine();
        }
    }
}
