using System;
using System.Text;

namespace CifradoC
{
    public class Cipher
    {
        public static string Encrypt(string text, int shift)
        {
            if (text == null)
    {
        throw new ArgumentNullException(nameof(text), "El parámetro 'text' no puede ser nulo.");
    }
            StringBuilder result = new StringBuilder();

            foreach (char character in text)
            {
                if (char.IsLetter(character))
                {
                    char baseASCII = char.IsUpper(character) ? 'A' : 'a';
                    result.Append((char)(((character + shift - baseASCII) % 26) + baseASCII));
                }
                else if (character >= '1' && character <= '9')
                {
                    result.Append((char)((character + shift - '1') % 9 + '1'));
                }
                else
                {
                    result.Append(character);
                }
            }

            return result.ToString();
        }

        public static string Decrypt(string text, int shift)
        {
            if (text == null)
            {
              throw new ArgumentNullException(nameof(text), "El parámetro 'text' no puede ser nulo.");
            }
            StringBuilder result = new StringBuilder();
            int charShift = 26 - shift;
            int numShift = 9 - shift;

            foreach (char character in text)
            {
                if (char.IsLetter(character))
                {
                    char baseASCII = char.IsUpper(character) ? 'A' : 'a';
                    result.Append((char)(((character + charShift - baseASCII) % 26) + baseASCII));
                }
                else if (character >= '1' && character <= '9')
                {
                    result.Append((char)((character + numShift - '1') % 9 + '1'));
                }
                else
                {
                    result.Append(character);
                }
            }

            return result.ToString();
        }
    }
}


