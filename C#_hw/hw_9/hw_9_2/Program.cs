// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.

// Ввод данных с клавиатуры (двух чисел) и нахождение суммы всех целых числе между ними включительно
int SumBetween()
{
    Console.WriteLine("Введите первое число");
    int firstNumber = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine("Введите второе число");
    int secondNumber = int.Parse(Console.ReadLine() ?? "0");
    int totalSum = 0;
    for (int i = Math.Min(firstNumber, secondNumber); i < Math.Max(firstNumber, secondNumber)+1; i++)
    {
        totalSum += i;
    }
    return totalSum;
}

Console.WriteLine($"Сумма = {SumBetween()}");
