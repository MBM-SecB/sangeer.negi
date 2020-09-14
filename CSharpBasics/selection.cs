
using System;
namespace SelectAndLoop
{
    class selection
    {
        static void Main123()
        {
            selection s = new selection();
            s.Learnswitchstatements();
        }
        void CheckNumber()
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();

            int number = int.Parse(input);

            if (number % 2 == 0)
            {
                Console.WriteLine("You entered EVEN number.");
            }
            else
            {
                Console.WriteLine("You entered ODD number.");
            }
        }
        void Learnswitchstatements()
        {
            Console.Write("Enter your hobby: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "books":
                    Console.WriteLine("you like books good");
                    break;
                default:
                    Console.WriteLine("You dont like books then thats kinda sad.");
                    break;
            }
        }
    }
}