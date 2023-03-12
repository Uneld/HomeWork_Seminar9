System.Console.Clear();
System.Console.Write("Введите чило = ");
double n = Convert.ToDouble(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    System.Console.Write($"{Math.Pow(i, 3)} ");
}