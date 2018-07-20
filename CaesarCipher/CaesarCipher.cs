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
            if (shiftKey >= 26)
            {
                while (shiftKey >= 26)
                {
                    shiftKey = shiftKey % 26;
                }
            }
            foreach (char letter in text)
            {
                char character;
                int temp;
                if ('A' <= letter && letter <= 'Z')
                {
                    temp = letter + shiftKey;
                    while(temp>=91)
                    {
                        temp -= 26;
                    }
                    character = (char)temp;
                    resultstring.Append(character);
                }
                else if ('a' <= letter && letter <= 'z')
                {
                    temp = letter + shiftKey;
                    while (temp >= 123)
                    {
                        temp -= 26;
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
