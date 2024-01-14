// Задача 4: Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую. 
// Допускается вывод цифр в обратном порядке, например: 3462 => 2,6,4,3


using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число Number: ");
        int Number = Convert.ToInt32(Console.ReadLine());
        
        int NumberLen;
        NumberLen = Number.ToString().Length;
        // Console.WriteLine("The length of integer variable is: " + NumberLen);

        if (NumberLen == 1)
        {
            Console.WriteLine(Number);
        }
        else
        {
            while (Number > 0)
            {
                int Remains = Number % 10;
                Number = Number / 10;

                if (Number > 0)
                {
                    Console.Write(Remains + ", ");
                }
                else
                {
                Console.WriteLine(Remains);
                }
            }
        }
    }
}
