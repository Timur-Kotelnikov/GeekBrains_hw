// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//Ввод данных и задание размеров массива
int ReadData(string someLine)
{
    Console.WriteLine(someLine);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

int amountLines = ReadData("Введите количество строк массива");
int amoutColumns = ReadData("Введите количество столбцов массива");

//Создание массива заданных размеров и его наполнение
double[,] CreateArray(int someNumberLines, int someNumberColumns)
{
    double[,] someArray = new double[someNumberLines, someNumberColumns];
    Random rnd = new Random();
    for (int i = 0; i < someNumberLines; i++)
    {
        for (int j = 0; j < someNumberColumns; j++)
        {
            someArray[i, j] = Math.Round(rnd.NextDouble() * 100, 2);
        }
    }
    return someArray;
}

double[,] myArray = CreateArray(amountLines, amoutColumns);

//Вывод результата
void PrintResult(double[,] someArray)
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

PrintResult(myArray);