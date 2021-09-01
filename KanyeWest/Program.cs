using System;
using Newtonsoft.Json.Linq;
using System.Net.Http;
namespace KanyeWest
{
    class Program
    {
        static void Main(string[] args)
        {

            QuoteGenerator.RonQuote();
            QuoteGenerator.KanyeQuote();
            QuoteGenerator.ChuckQuote();

        }

    }
}
