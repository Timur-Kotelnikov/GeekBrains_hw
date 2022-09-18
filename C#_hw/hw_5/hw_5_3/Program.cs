//  Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.

// Ввод данных и задание длины массива
int ReadData(string SomeLine)
{
    Console.WriteLine(SomeLine);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

int LengthOfArray = ReadData("Введите длину массива");

// Создание массива (случайные значения от 0 до 100)
double[] CreateArray(int ArrayLength)
{
    double[] SomeArray = new double [ArrayLength];
    Random rnd = new Random();
    for (int i = 0; i < ArrayLength; i ++)
    {
        SomeArray[i] = rnd.NextDouble() * 100;
    }
    return SomeArray;
}

double[] array = CreateArray(LengthOfArray);

// Нахождение минимума в массиве
double FindMinInArray(double[] SomeArray)
{
    double MinNumInArray = SomeArray[0];
    foreach (double i in SomeArray)
    {
        if (i < MinNumInArray)
        {
            MinNumInArray = i;
        }
    }
    return MinNumInArray;
}

// Нахождение максимума в массиве
double FindMaxInArray(double[] SomeArray)
{
    double MaxNumInArray = SomeArray[0];
    foreach (double i in SomeArray)
    {
        if (i > MaxNumInArray)
        {
            MaxNumInArray = i;
        }
    }
    return MaxNumInArray;
}

// Вывод результата
void PrintResult(double[] SomeArray)
{
    Console.WriteLine($"Итог: {FindMaxInArray(SomeArray)} - {FindMinInArray(SomeArray)} = {FindMaxInArray(SomeArray) - FindMinInArray(SomeArray)}");
}


for (int i = 0; i < array.Length-1; i ++)
{
    Console.Write($"{array[i]}  ");
}
Console.WriteLine(array[array.Length-1]);

PrintResult(array);