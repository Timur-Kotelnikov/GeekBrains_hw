// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в 
// натуральную степень B.
Console.WriteLine("First Number: ");
string? inputLine1 = Console.ReadLine();
Console.WriteLine("Second Number: ");
string? inputLine2 = Console.ReadLine();
if (inputLine1 != null && inputLine2 != null)
{
    double inputNumber1 = double.Parse(inputLine1);
    double inputNumber2 = double.Parse(inputLine2);
    Console.WriteLine($"Result = {Math.Pow(inputNumber1, inputNumber2)}");
}
