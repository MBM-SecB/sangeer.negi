using System;
namespace FirstCharacterInitial
{
    class FirstCharacter
    {
        static void Main()
        {
            Console.WriteLine("Enter your name");
            string str = Console.ReadLine();
            Console.WriteLine(firstcharacter(str));
        }
        static string firstcharacter(string str)
        {
            string result = "";
            bool v = true;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    v = true;
                }
                else if (str[i] != ' ' && v == true)
                {
                    result += (str[i]);
                    v = false;
                }
            }
            return result;
        }
    }
}