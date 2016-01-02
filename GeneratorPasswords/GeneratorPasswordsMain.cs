using System;
using System.Text;

namespace GeneratorPasswords
{
    class GeneratorPasswordsMain
    {
        static void Main()
        {
            StringBuilder password = new StringBuilder();
            Random rnd = new Random();
            char[] capitalLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] smallLetters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            char[] numbers = "0123456789".ToCharArray();
            string spec = "~!@#$%^&*()_+=`{}[]\\|':;.,/?<>";
            char[] specChars = spec.ToCharArray();

            int passLenght = rnd.Next(9, 16);

            for (int i = 0; i < 2; i++)
            {
                password.Append(capitalLetters[rnd.Next(0, capitalLetters.Length)]);
            }

            for (int i = 0; i < 2; i++)
            {
                password.Append(smallLetters[rnd.Next(0, smallLetters.Length)]);
            }

                password.Append(numbers[rnd.Next(0, numbers.Length)]);

            for (int i = 0; i < 2; i++)
            {
                password.Append(specChars[rnd.Next(0, specChars.Length)]);
            }

            Console.WriteLine(password);

            for (int i = 0; i < passLenght-password.Length; i++)
            {
                char ins = specChars[rnd.Next(0,specChars.Length)];
                int ranpos = rnd.Next(0, 9);
                password.Insert(ranpos, ins);
            }

            Console.WriteLine(password);
        }
    }
}
