using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите число Х (от 10 до 99): ");
        int X = Convert.ToInt32(Console.ReadLine());
        int Digit = X / 10;
        int Remains = X % 10;

        
        if (Digit > Remains)
        {
            Console.WriteLine(Digit);
        }
        else
        {
            Console.WriteLine(Remains);
        }
    }
}