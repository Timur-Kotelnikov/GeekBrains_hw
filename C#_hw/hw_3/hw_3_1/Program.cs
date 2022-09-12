// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
string? inputLine = Console.ReadLine();
if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    if (inputNumber > 9999 && inputNumber < 100000)
    {
        Console.WriteLine(inputLine[0] == inputLine[4] && inputLine[1] == inputLine[3]);   
    }
}
