// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа.
string? inputLine = Console.ReadLine();
if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    if (inputNumber > 99 && inputNumber < 1000)
    {
        Console.WriteLine((inputNumber % 100) / 10);
    }
    else
    {
        Console.WriteLine("Please try another number (100 - 999)");
    }
}
