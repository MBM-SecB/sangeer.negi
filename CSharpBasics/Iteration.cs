using System;

namespace SelectAndLoop
{
    
}
class IterationStatement
{
        static void Main4488()
    {
        IterationStatement iterationStatement = new IterationStatement();
        iterationStatement.LearnWhileLoops();

        AccessModifier accessModifier = new AccessModifier();
        accessModifier.DoAnotherThing();

        Person person = new Person();
        person.SetAge(34);

    }
    void LearnForLoops()
    {
       for(int i=0;i<10;i++)
        {
            Console.WriteLine("Hello World!! :)");
        }
        byte[] personAges = {20,45,6,78,23};
        foreach(byte age in personAges)
        {
            if(age %2 ==0)
            {
                Console.WriteLine(age + " is EVEN");
            }
            else
            {
                Console.WriteLine(age + " is ODD");
            }
        }

    }

    void LearnWhileLoops()
    {
        char confirm = 'Y';
        while(confirm =='Y')
        {
            Console.WriteLine("I am inside While Loop");
            Console.Write("Enter Y to continue:");
            confirm = Console.ReadKey().KeyChar;
        }

        do
        {
            Console.WriteLine("I am inside While Loop");
            Console.Write("Enter Y to continue:");
            confirm = Console.ReadKey().KeyChar; 
        } 
        while(confirm =='Y');
    }
}