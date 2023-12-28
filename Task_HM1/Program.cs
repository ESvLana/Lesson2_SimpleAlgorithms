int a = 148;
int b = a % 7;
int c = a % 23;


if (b + c == 0)
{
    Console.WriteLine($"Число {a} - кратно 7 и 23");
}
else
{
    Console.WriteLine($"Число {a} - не кратно 7 и 23");
}


// using System;
// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите число: ");
//         int a = Convert.ToInt32(Console.ReadLine());


//         if (a % 7 == 0 && a % 23 == 0)
//         {
//             Console.WriteLine($"Число {a} - кратно 7 и 23");
//         }
//         else
//         {
//             Console.WriteLine($"Число {a} - не кратно 7 и 23");
//         }
//     }
// }