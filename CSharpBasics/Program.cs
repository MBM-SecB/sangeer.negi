using System;

namespace CSharpBasics
{
    class Program
    {
        static void Main()
        {
            var square1 =new Square(23.45);
            var square2 =new Square(4);
            var square3 =new Square(12);

            var rectangle=new Rectangle(23.5,12.2);
            rectangle.PrintResult();
 
            var x=square2.GetArea();
            Console.WriteLine($"Area:{x}");
        }
    }
}