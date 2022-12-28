int b = 2;
void Numbers(int a)
{
    if (b <= a)
    {
        Console.WriteLine(b);
        b = b + 2;
        Numbers(a);
        int b = 2;
    }
}

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
Numbers(a);