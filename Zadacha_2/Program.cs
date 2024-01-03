// Напишите программу вычисления функции Аккермана
//  с помощью рекурсии. Даны два неотрицательных числа m и n. 
//  m = 2, n = 3 -> A(m,n) = 29

System.Console.WriteLine("Введите число m : ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число n : ");
int n = Convert.ToInt32(Console.ReadLine());
int result = AckermansFunction(m, n);
Console.WriteLine($"A({m}, {n}) = {result}");

int AckermansFunction(int num1, int num2)
{
    if (num1 == 0)
    {
        return num2 + 1;
    }
    else if (num2 == 0)
    {
        return AckermansFunction(num1 - 1, 1);
    }
    else
    {
        return AckermansFunction(num1 - 1, AckermansFunction(num1, num2 - 1));
    }
}

