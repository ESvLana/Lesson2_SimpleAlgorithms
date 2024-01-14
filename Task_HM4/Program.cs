// Задача 4: Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую. 
// Допускается вывод цифр в обратном порядке, например: 3462 => 2,6,4,3

// int number = 456321;
// int number.ToString().Length

using System;

class Program
{
    static void Main()
    {
        int number = 332592241;
        
        int numberLen;
        numberLen = number.ToString().Length;
        Console.WriteLine("The length of integer variable is: " + numberLen);

        int Digit = number / 10;
        int Remains = number % 10;
        int NewNumder = Remains * 10;
        int NewNumderLen;
        NewNumderLen = NewNumder.ToString().Length;
        
        int X;
        int Y;

        
        if (Digit != 0)
        {
            X = Digit % 10;
            Y = number / 10;
            NewNumder = (NewNumder + X) * 10;
            Console.WriteLine("The length of integer variable is: " + NewNumderLen);
        }
        Console.WriteLine(NewNumder);
    }
}




//     while(n!=0)
//     {
//                r=n%10;
//                n=n/10;

//                cout<<r;
//     }
//     cout<<endl;

//     system("PAUSE");
//     return 0;
// }