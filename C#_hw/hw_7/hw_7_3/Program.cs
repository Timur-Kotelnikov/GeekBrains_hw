// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Ввод данных и задание размеров массива
int ReadData(string someLine)
{
    Console.WriteLine(someLine);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

int amountLines = ReadData("Введите количество строк массива");
int amoutColumns = ReadData("Введите количество столбцов массива");

// Создание массива заданного размера
int[,] CreateArray(int someNumberLines, int someNumberColumns)
{
    int[,] someArray = new int[someNumberLines, someNumberColumns];
    Random rnd = new Random();
    for (int i = 0; i < someNumberLines; i++)
    {
        for (int j = 0; j < someNumberColumns; j++)
        {
            someArray[i, j] = rnd.Next(-100, 100);
        }
    }
    return someArray;
}

int[,] myArray = CreateArray(amountLines, amoutColumns);

//Вывод массива
void PrintArray(int[,] someArray)
{
    Console.WriteLine("Созданный массив:");
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        for (int j = 0; j < someArray.GetLength(1); j++)
        {
            Console.Write($"{someArray[i, j]} ");
        }
    Console.WriteLine();
    }
}
PrintArray(myArray);

//
void PrintResult(int[,] someArray)
{
    Console.WriteLine("Среднее арифметическое каждого столбца:");
    int j = 0;
    while (j < someArray.GetLength(1))
    {
        int subSum = 0;
        for (int i = 0; i < someArray.GetLength(0); i++)
            {
                subSum += someArray[i, j];
            }
        double subSumDouble = subSum;
        double lengthDouble = someArray.GetLength(0);
        double subResult = Math.Round(subSumDouble/lengthDouble, 2);
        Console.Write($"{subResult} ");
        j += 1;
    }
    
}
PrintResult(myArray);