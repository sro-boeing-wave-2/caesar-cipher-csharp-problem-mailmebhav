using System;
using System.Linq;
using System.Text;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
            StringBuilder resultstring = new StringBuilder("");
            int numberOfAlphabets = 26;
            int AsciiValueofz = 123;
            int AsciiValueOfZ = 91;
            if (shiftKey >= numberOfAlphabets)
            {
                while (shiftKey >= numberOfAlphabets)
                {
                    shiftKey = shiftKey % numberOfAlphabets;
                }
            }
            foreach (char letter in text)
            {
                char character;
                int temp;
                if ('A' <= letter && letter <= 'Z')
                {
                    temp = letter + shiftKey;
                    while(temp>=AsciiValueOfZ)
                    {
                        temp -= numberOfAlphabets;
                    }
                    character = (char)temp;
                    resultstring.Append(character);
                }
                else if ('a' <= letter && letter <= 'z')
                {
                    temp = letter + shiftKey;
                    while (temp >= AsciiValueofz)
                    {
                        temp -= numberOfAlphabets;
                    }
                    character = (char)temp;
                    resultstring.Append(character);
                }
                else
                {
                    resultstring.Append(letter);
                }
            }
            return resultstring.ToString();
        }
    }
}
