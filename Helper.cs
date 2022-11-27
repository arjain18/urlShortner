using System.Collections;
using System.Collections.Generic;

namespace UrlShortner
{
    public class Helper
    {
        static IDictionary<string, string> d = new Dictionary<string, string>();
        static string path = @"\mydir\";
        static string pathFolder = "source";
        static string fileName = "myfile.txt";
        static string completePathFolder = Path.Combine(Path.GetPathRoot(path), pathFolder);
        static string completePathFile = Path.Combine(Path.GetPathRoot(path), pathFolder, fileName);
        public static string GenerateShortUrl()
        {
            Random rand = new Random();

            // Choosing the size of string
            //int stringlen = rand.Next(4, 10);
            int stringlen = 5;
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
            if (!Directory.Exists(completePathFolder))
                Directory.CreateDirectory(completePathFolder);
            // using (StreamWriter file = new StreamWriter("c:\\source\\myfile.txt", append: true))
            using (StreamWriter file = new StreamWriter(completePathFile, append: true))
                file.WriteLine("[{0} {1}]", keyUrl, valueUrl);

        }
        public static string ReadList(string keyUrl)
        {
            string urlValue = "";
            try
            {
                // Open the text file using a stream reader.
                using (var sr = new StreamReader(completePathFile))
                {
                   
                    // Read the stream as a string
                    string strFileString = sr.ReadToEnd();

                    // write the string to the console.
                    Console.WriteLine(strFileString);

                    //check for the string
                    string keyUrlSearch = keyUrl + " "; //extra space is added to get complete url not as sub string
                    int keyUrlSearchLen = keyUrlSearch.Length;

                    if (strFileString.Contains(keyUrlSearch))
                    {
                        int i = strFileString.IndexOf(keyUrlSearch);
                        i = i + keyUrlSearchLen;

                        //reading value
                        int k = i + 20;
                        urlValue = strFileString.Substring(i, 20);
                    }
                                     

                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            return urlValue;
        }
    }
}
