using System;
using System.Linq;
using System.Text;

namespace AtbashCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string plaintext = "Skrmiish is awesome!";
            Console.WriteLine("Plain Text  = " + plaintext);
            string encoded = Atbash(plaintext);
            Console.WriteLine("Encoded Text  = " + encoded);
            string decoded = Atbash(encoded);
            Console.WriteLine("Decoded Text  = " + decoded);

        }
        static string Atbash(string plainText)
        {
            string encodedString = "";
            foreach(char c in plainText)
            {
                if ((c < 'a' || c > 'z') && (c < 'A' || c > 'Z'))
                {
                    encodedString += c;
                }
                //a - z 97 to 122
                // 97 + 122 = 219
                // 219 - 97 = 122, 219 - 98 = 121
                else if (c >= 'a' && c <= 'z')
                {
                    encodedString += ((char)(219 - c));
                }
                //A - Z = 65 - 90
                // 155
                else if (c >= 'A' && c <= 'Z')
                {
                    encodedString += ((char)(155 - c));
                }
            }

            return encodedString;
        }
    }
}
