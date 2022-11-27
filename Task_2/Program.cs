// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int SumNumbersMN(int m, int n)
{
    int sum = m;
    if (n < m)
    {
        return 0;
    }
    return sum + SumNumbersMN(m + 1, n);
}

int m = Prompt("Введите натуральное число M: ");
int n = Prompt("Введите натуральное число N: ");
Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n}: {SumNumbersMN(m, n)}");