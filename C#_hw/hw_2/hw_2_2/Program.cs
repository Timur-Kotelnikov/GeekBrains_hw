// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
string? inputLine = Console.ReadLine();
if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    if (inputNumber > 99)
    {
        Console.WriteLine(inputLine[2]);
    }
    else
    {
        Console.WriteLine("Please try another number (At least 3 digits)");
    }
}
