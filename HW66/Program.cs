// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void SummNumbers(int start, int end, int summ)
{
    summ += start;
    if (start == end)
    {
        Console.WriteLine(summ);
        return;
    }
    SummNumbers(start + 1, end, summ);
}

Console.Clear();
Console.Write("Введите M и N через пробел: ");
string? ins = Console.ReadLine();
string[] mn = ins.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int m = Convert.ToInt32(mn [0]);
int n = Convert.ToInt32(mn [1]);
while (m > n)
{
    Console.Write("M должно быть меньше N. Введите ещё раз: ");
    ins = Console.ReadLine();
    mn = ins.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    m = Convert.ToInt32(mn[0]);
    n = Convert.ToInt32(mn[1]);
}
int startSumm = 0;
SummNumbers(m, n, startSumm);
