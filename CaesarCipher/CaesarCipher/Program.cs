using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter encryption text:\n");
            string encryptStr = Console.ReadLine();
            Console.WriteLine("Enter encryption key:\n");
            int enKey = Convert.ToInt32(Console.ReadLine());

            Cipher c = new Cipher();

            Console.WriteLine("Encrypted text: ");
            string cipher = c.Encrypt(encryptStr, enKey);
            Console.WriteLine(cipher);
            Console.WriteLine("\n");

            Console.WriteLine("Decrypted text: ");
            string putBack = c.Decrypt(cipher, enKey);
            Console.WriteLine(putBack);
            Console.WriteLine("\n");
        }
    }
}
