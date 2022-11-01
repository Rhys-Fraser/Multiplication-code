using System;

class Program
{
    public static void Main(string[] args)
    {
        int numberFixed, numberInput;

        Console.Write("\n\n");
        Console.Write("Display the multiplication table:\n");
        Console.Write("-----------------------------------");
        Console.Write("\n\n");

        Console.Write("Input the number (Table to be calculated) : ");

        numberInput = Convert.ToInt32(Console.ReadLine());
        Console.Write("\n");

        for (numberFixed = 1; numberFixed <= 10; numberFixed++)
        {
            Console.Write("{0} x {1} = {2} \n", numberInput, numberFixed, numberInput * numberFixed);
        }

        Console.ReadLine();
    }
}