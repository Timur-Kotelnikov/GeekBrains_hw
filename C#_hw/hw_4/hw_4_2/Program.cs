// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
string? inputLine = Console.ReadLine();
if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    Console.WriteLine((Math.Log10(inputNumber) - (Math.Log10(inputNumber) % 1)) + 1);
}
