// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int FunctionAccMN(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
        if ((m != 0) && (n == 0))
            return FunctionAccMN(m - 1, 1) + n;
        else
            return FunctionAccMN(m - 1, FunctionAccMN(m, n - 1));
}

int m = Prompt("Введите натуральное число M: ");
int n = Prompt("Введите натуральное число N: ");
Console.WriteLine
($"Функция Аккермана для чисел {m} и {n}: {FunctionAccMN(m, n)}");