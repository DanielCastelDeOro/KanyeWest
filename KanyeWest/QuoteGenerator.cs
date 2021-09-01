using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json.Linq;


namespace KanyeWest
{
    public class QuoteGenerator
    {
        public static void KanyeQuote()
        {
            var client = new HttpClient();

            var kanyeURL = "https://api.kanye.rest";

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            Console.WriteLine("-----------------------");
            Console.WriteLine($"Kanye: '{kanyeQuote}'");
            Console.WriteLine("-----------------------");
        }

        public static void RonQuote()
        {
            var client = new HttpClient();

            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronResponse = client.GetStringAsync(ronURL).Result;

            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            Console.WriteLine("-----------------------");
            Console.WriteLine($"Ron: '{ronQuote}'");
            Console.WriteLine("-----------------------");
        }

        public static void ChuckQuote()
        {
            var client = new HttpClient();

            var chuckURL = "https://api.chucknorris.io/jokes/random";

            var chuckResponse = client.GetStringAsync(chuckURL).Result;

            var chuckQuote = JObject.Parse(chuckResponse).GetValue("value").ToString();

            // var ronQuote = JArray.Parse(chuckResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            Console.WriteLine("-----------------------");
            Console.WriteLine($"Chuck: '{chuckQuote}'");
            Console.WriteLine("-----------------------");
        }
    }
}
