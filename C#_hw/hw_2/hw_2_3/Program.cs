// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
string? inputLine = Console.ReadLine();
if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    if (inputNumber > 0 && inputNumber < 8)
    {
        Console.WriteLine(inputNumber == 6 | inputNumber == 7);
    }
    else
    {
        Console.WriteLine("Please try another number (1-7)");
    }
}
