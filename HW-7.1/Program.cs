// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

Console.WriteLine("Задайте натуральные M и N, и мы выведем все натуральные числа в промежутке от M до N:");
int numM = int.Parse(Console.ReadLine()!);
int numN = int.Parse(Console.ReadLine()!);

void PrintRangeNumbers(int numM, int numN)
{
    if (numM < 1 | numN < 1)
    {
        Console.WriteLine("| натуральные числа - это положительные целые числа от 1 до бесконечности");
        return;  // не комментить! Сигнал для прерывания
    }
    if (numM <= numN) 
    {
        Console.WriteLine(numM);
        PrintRangeNumbers(numM + 1, numN);  
    }
}

PrintRangeNumbers(numM, numN);