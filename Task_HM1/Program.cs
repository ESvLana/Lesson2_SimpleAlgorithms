int a = 91;
int b = a % 7;
int c = a % 13;

if (b + c == 0)
{
    Console.WriteLine("Число " + a + " - кратно 7 и 13");
}
else
{
    Console.WriteLine("Число " + a + " - не кратно 7 и 13");
}