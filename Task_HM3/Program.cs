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






// class RIN
// {
//     int min = 10;    // нижняя граница
//     int max = 99;  // верхняя граница
//     public string info = "число"; // имя параметра
//     public bool n_bool; // успешность преобразования

//     // Ограниченное число: поле n и свойство N
//     int n;
//     public int N    // свойство
//     {
//         get { return n; }
//         set
//         {
//             if (value < min)
//             {
//                 n = min;
//                 n_bool = false;
//             }
//             else if (value > max)
//             {
//                 n = max;
//                 n_bool = false;
//             }
//             else
//             {
//                 n = value;
//                 n_bool = true;
//             }
//         }
//     }

//     // конструктор
//     public RIN(string n_st, int n_min, int n_max, int n_def, string n_info)
//     {
//         min = n_min;
//         max = n_max;
//         info = n_info;
//         n_bool = true;
//         try
//         {
//             N = Convert.ToInt32(n_st);
//             if (!n_bool)
//             {
//                 info = "Ошибка ввода параметра << " + info + " >>. Число вне диапазона. Автоматически присваивается нижняя/верхняя граница. Для изменения введите целое число от " + min.ToString() + " до " + max.ToString();
//             }
//         }
//         catch
//         {
//             info = "Ошибка ввода параметра << " + info + " >>. Введите целое число от " + min.ToString() + " до " + max.ToString() + ". По умолчанию параметр =  " + n_def.ToString(); ;
//             n = n_def;
//             n_bool = false;
//         }
//     }
// }   // end class RIN
// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Введите двухзначное целое число: ");
//         string number = Console.ReadLine();

//         RIN k = new RIN(number, 10, 99, 55, "число");
//         int n = k.N;

//         Console.WriteLine("Ваше число: {0}", n);

//         if (!k.n_bool)
//             Console.WriteLine(k.info);

//         Console.ReadKey();
//     }
// }

// using System;

// public class Example
// {
//    public static void Main()
//    {
//       string[] values = { null, "160519", "9432.0", "16,667",
//                           "   -322   ", "+4302", "(100);", "01FA" };
//       foreach (var value in values)
//       {
//          int number;

//          bool success = int.TryParse(value, out number);
//          if (success)
//          {
//             Console.WriteLine($"Converted '{value}' to {number}.");
//          }
//          else
//          {
//             Console.WriteLine($"Attempted conversion of '{value ?? "<null>"}' failed.");
//          }
//       }
//    }
// }