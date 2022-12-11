// *. Напишите программу вычисления модуля числа.

string s_N = Console.ReadLine();
int N = int.Parse(s_N);

if (N < 0)
{
    N = -N;
}

Console.Write(N);

// **. Напишите программу, которая на вход принимает значение, а
// на выходе показывает обратное значение.

string s_N = Console.ReadLine();
float N = float.Parse(s_N);

Console.Write($"{N} -> {1 / N}");