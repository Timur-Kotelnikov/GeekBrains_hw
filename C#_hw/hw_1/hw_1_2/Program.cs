// Задача 4: Напишите программу, которая принимает на вход 
// три числа и выдаёт максимальное из этих чисел.
string? inputLine1 = Console.ReadLine();
string? inputLine2 = Console.ReadLine();
string? inputLine3 = Console.ReadLine();
if (inputLine1 != null && inputLine2 != null && inputLine3 != null)
{
    int inputNumber1 = int.Parse(inputLine1);
    int inputNumber2 = int.Parse(inputLine2);
    int inputNumber3 = int.Parse(inputLine3);
    int maxNumber = 0;
    maxNumber = Math.Max(Math.Max(inputNumber1, inputNumber2), inputNumber3);

    Console.WriteLine($"Max = {maxNumber}");
}
