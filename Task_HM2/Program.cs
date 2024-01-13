using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите X: ");
        int X = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите Y: ");
        int Y = Convert.ToInt32(Console.ReadLine());


        if (X > 0 && Y > 0)
        {
            Console.WriteLine($"Точка с координатами ({X};{Y}) находится в первой координатной четверти плоскости");
        }
        if (X < 0 && Y > 0)
        {
            Console.WriteLine($"Точка с координатами ({X};{Y}) находится во ыторой координатной четверти плоскости");
        }
        if (X < 0 && Y < 0)
        {
            Console.WriteLine($"Точка с координатами ({X};{Y}) находится в третьей координатной четверти плоскости");
        }
        if (X > 0 && Y < 0)
        {
            Console.WriteLine($"Точка с координатами ({X};{Y}) находится в четвертой координатной четверти плоскости");
        }
    }
}