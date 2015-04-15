using System;
class PrintLongSequence
{
    static void Main()
    {
        for (int number = 2; number < 1000; number++)
            if (number % 2 == 0)
                Console.Write("{0},", number);
            else
                Console.Write("-{0},", number);
    }
}