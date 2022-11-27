// Задайте значения M и N. Напишите программу, которая выведет 
// все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void PrintNumbersMN(int m, int n)
{
    if (n < m)
    {
        return;
    }
    if (m % 2 != 0)
    {
        m += 1;
    }
    Console.Write($"{m} ");
    PrintNumbersMN(m + 2, n);
}

int m = Prompt("Введите число M: ");
int n = Prompt("Введите число N: ");
PrintNumbersMN(m, n);