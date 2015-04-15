//Problem 9. Print a Sequence

//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

using System;
class PrintSequence2To12
{
    static void Main()
    {
        for (int number = 2; number < 12; number++)
        if (number % 2 == 1)
            Console.Write("{0},", number);
        else
            Console.Write("-{0},", number);
            Console.WriteLine();
    }
}