namespace UrlShortner
{
    public class Helper
    {
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
    }
}
