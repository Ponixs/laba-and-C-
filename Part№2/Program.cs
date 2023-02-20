using System;

namespace Part_2
{
    class Program
    {
        static int Main()
        {
            String name, surname, result = "";
            name = Console.ReadLine();
            surname = Console.ReadLine();
            foreach (var letter in name) if (!char.IsLetter(letter)) return -1;
            foreach (var letter in surname) if (!char.IsLetter(letter)) return -1;

            int i = 0;
            for (; i < name.Length && i < surname.Length; i++)
            {
                int ok = name[i] + surname[i];
                Console.WriteLine($"число: {ok} \tсимвол:{(char)ok}.");
                result += (char)ok;
            }


            if (name.Length > surname.Length) result += name.Substring(i);
            else result += surname.Substring(i);
            Console.WriteLine(result);
            return 0;
        }
    }
}
