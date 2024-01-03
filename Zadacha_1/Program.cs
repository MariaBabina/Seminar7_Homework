﻿// Задайте значения M и N. Напишите программу, которая выведет
//  все натуральные числа в промежутке от M до N. 
//  Использовать рекурсию, не использовать циклы.
// Пример M = 1; N = 5 -> "1, 2, 3, 4, 5" 
// M = 4; N = 8 -> "4, 5, 6, 7, 8"




int firstNum = new Random().Next(1,10); 
int lastNum = firstNum + new Random().Next(1,10); 

System.Console.WriteLine(firstNum + ", " + lastNum);

PrintNumbers(firstNum, lastNum);

void PrintNumbers(int startNum, int endNum)
{
    System.Console.WriteLine(startNum);
    if (startNum >= endNum)
    {
        return;
    }
    PrintNumbers(startNum + 1, endNum);
}
