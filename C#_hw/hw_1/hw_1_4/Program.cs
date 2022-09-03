// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе 
// показывает все чётные числа от 1 до N.
string? inputLine = Console.ReadLine();
if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    int i = 1;
    while (i < inputNumber+1)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(i);
        }
        i++;
    }
}


