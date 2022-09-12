// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N
string? inputLine = Console.ReadLine();
if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    double[] result = new double[inputNumber];
    for (int i = 0; i < result.Length; i ++)
    {
        result[i] = Math.Pow((i+1), 3);
    }
    foreach (double item in result)
    {
        Console.WriteLine(item);
    }
}
