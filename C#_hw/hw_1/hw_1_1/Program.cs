// Задача 2: Напишите программу, которая на вход принимает 
// два числа и выдаёт, какое число большее, а какое меньшее.
string? inputLine1 = Console.ReadLine();
string? inputLine2 = Console.ReadLine();
if (inputLine1 != null && inputLine2 != null)
{
    int inputNumber1 = int.Parse(inputLine1);
    int inputNumber2 = int.Parse(inputLine2);
    if (inputNumber1 == inputNumber2)
    {
        Console.WriteLine("Numbers are equal");
    }
    else
    {
        Console.WriteLine($"Max = {Math.Max(inputNumber1, inputNumber2)}");
    }
}

