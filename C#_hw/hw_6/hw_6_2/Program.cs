// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// Ввод данных и задание коэффициентов уравнений
int ReadData(string SomeLine)
{
    Console.WriteLine(SomeLine);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}
int k1 = ReadData("k1 =");
int b1 = ReadData("b1 =");
int k2 = ReadData("k2 =");
int b2 = ReadData("b2 =");

// Решение уравнения (определение искомой координаты Х)
double GetResult(int NumberOne, int NumberTwo, int NumberThree, int NumberFour)
{
    double result = (b2 - b1)/(k1 - k2);
    return result;
}

// Вывод результата
void PrintResult(int k1, int b1, int k2, int b2)
{
    if (k1 != k2)
    {
        Console.WriteLine($"x = {GetResult(k1, b1, k2, b2)}, y = {k1 * (GetResult(k1, b1, k2, b2)) + b1}");
    }
    else
    {
        Console.WriteLine("Прямые параллельны");
    }
}
PrintResult(k1, b1, k2, b2);