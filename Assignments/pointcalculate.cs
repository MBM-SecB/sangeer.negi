using System;
class PointCalculate
{
    static void Main444()
    {
        PointCalculate p = new PointCalculate();
        p.Combine();
    }
    void Combine()
    {
        Console.Write("Enter the number of Wins, Draws and Lose:");
        string input1 = Console.ReadLine();
        string input2 = Console.ReadLine();
        string input3 = Console.ReadLine();
        int w = int.Parse(input1);
        int d = int.Parse(input2);
        int l = int.Parse(input3);
        int k = 5*w + 2*d + 0*l;
        Console.Write("The total number of points you have obtained is:{0}", k);
    }
}