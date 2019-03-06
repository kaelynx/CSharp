using System;
namespace CaesarCipher
{
    public class Cipher
    { 
        private const int alpha = 26;

        public string Encrypt(string str, int key)
        {
            string encipher = string.Empty;
            foreach(char c in str)
            {
                encipher += ToCipher(c, key);
            }
            return encipher;
        }

        public string Decrypt(string str, int key)
        {
            string original = Encrypt(str, (alpha - key));
            return original;
        }

        public char ToCipher(char c, int key)
        {
            if (!char.IsLetter(c))
            {
                // keep spaces and punctuation
                return c;
            }
            else
            {
                char temp = char.IsUpper(c) ? 'A' : 'a';
                char result = (char)((((c + key) - temp) % alpha) + temp);
                return result;
            }
        }
    }
}
