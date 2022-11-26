using System.Collections;
using System.Collections.Generic;

namespace UrlShortner
{
    public class Helper
    {
        static IDictionary<string, string> d = new Dictionary<string, string>();
        public static string GenerateShortUrl()
        {
            Random rand = new Random();

            // Choosing the size of string
            int stringlen = rand.Next(4, 10);
            int randValue;
            string shortUrl = "";
            char letter;
            for (int i = 0; i < stringlen; i++)
            {
                // Generating a random number.
                randValue = rand.Next(0, 26);
                // Generating random character by converting the random number into character.
                letter = Convert.ToChar(randValue + 65);
                // Appending the letter to string.
                shortUrl = shortUrl + letter;
            }
             return shortUrl = "www.shorty.com/" + shortUrl;
        }
        public static void AddList(string keyUrl, string valueUrl)
        {
            d.Add(keyUrl, valueUrl);
            using (StreamWriter file = new StreamWriter("myfile.txt", append: true))
               // foreach (var entry in d)
                    file.WriteLine("[{0} {1}]", keyUrl, valueUrl);
            string str;
            foreach (KeyValuePair<string, string> ele in d)
            {
                Console.WriteLine("Key = {0}, Value = {1}", ele.Key, ele.Value);
                if (d.TryGetValue("1", out str))
                {
                    Console.WriteLine(ele.Value);
                }

            }
        }
    }
}
