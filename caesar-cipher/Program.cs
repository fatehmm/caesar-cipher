using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alph = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            string message;

            do
            {
                Console.Write("hansi mesaji sifrelemek isteyirsen...");
                message = Console.ReadLine();
            } while (message == null);

             
            char[] secretMessage = message.ToCharArray();
            char[] encryptedMessage = new char[secretMessage.Length];

            Console.Write("sifrenin acari olan ededi yaz...");
            int keyNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < secretMessage.Length; i++)
            {
                char character = secretMessage[i];

                int index = Array.IndexOf(alph, character);
                index = (index + keyNumber) % 26;

                secretMessage[i] = alph[index];
            }

            Console.WriteLine(String.Join("", secretMessage));
        }
    }
}


