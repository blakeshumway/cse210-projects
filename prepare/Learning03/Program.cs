using System;

class Program
{
    static void Main(string[] args)
    {
        //test 1
        Fraction test1 = new Fraction();

        Console.WriteLine(test1.GetFractionString());
        Console.WriteLine(test1.GetDecimalValue());

        //test 2
        Fraction test2 = new Fraction(5);

        Console.WriteLine(test2.GetFractionString());
        Console.WriteLine(test2.GetDecimalValue());

        //test 3
        Fraction test3 = new Fraction(3, 4);

        Console.WriteLine(test3.GetFractionString());
        Console.WriteLine(test3.GetDecimalValue());

        //test 4
        Fraction test4 = new Fraction(1, 3);

        Console.WriteLine(test4.GetFractionString());
        Console.WriteLine(test4.GetDecimalValue());


    
    
       }
}