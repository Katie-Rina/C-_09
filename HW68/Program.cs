// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akker(int a, int b)
{
        if (a == 0) return b + 1;
        else if (b == 0) return Akker(a - 1, 1);
             else return Akker(a - 1, Akker(a, b - 1));
}

Console.Clear();
Console.Write("Введите m и n через пробел: ");
string? ins = Console.ReadLine();
string[] mn = ins.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int m = Convert.ToInt32(mn [0]);
int n = Convert.ToInt32(mn [1]);
int akk = Akker(m, n);
Console.WriteLine($"A({m}, {n}) = {akk}");





