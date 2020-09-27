using System;
class NumberCompare
{
    static void Main2()
    {
        NumberCompare n = new NumberCompare();
        n.CompareTwoNumbers();
    }
    void CompareTwoNumbers()
    {
        int a = 250;
        int b = 350;
        int c = a+b;
        bool k = true;
        bool l = false;
        if(c >=500)
        {
            Console.WriteLine(k);
        }
        else
        {
            Console.WriteLine(l);
        }
    }
}