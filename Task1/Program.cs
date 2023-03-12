int сountDigits(int n)
{
    int count;

    if (n == 0) count = 1;
    else count = 0;

    while (n != 0)
    {
        n /= 10;
        count++;
    }

    return count;
}

string checkPalindrome(int number)
{
    int[] digit = new int[5];
    for (int i = 1; i < 5; i++)
    {
        int step = digit.Length - i;
        digit[step] = number % 10;
        number /= 10;
    }
    digit[0] = number;

    if (digit[0] == digit[4] && digit[1] == digit[3])
    {
        return "Введенное число является палиндромом";
    }
    else
    {
        return "Введенное число не является палиндромом";
    }
}

System.Console.Clear();
System.Console.WriteLine("Введите пятизначное число число");
int a = Convert.ToInt32(Console.ReadLine());
if (сountDigits(a) == 5)
{
    System.Console.WriteLine(checkPalindrome(a));
}
else
{
    System.Console.WriteLine("Не верно введено число");
}


