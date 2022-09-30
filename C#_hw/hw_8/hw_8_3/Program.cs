// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц

// Создание матрицы
int[,] CreateArray(int amountLines, int amoutColumns)
{
    int[,] someArray = new int[amountLines, amoutColumns];
    Random rnd = new Random();
    for (int i = 0; i < amountLines; i++)
    {
        for (int j = 0; j < amoutColumns; j++)
        {
            someArray[i, j] = rnd.Next(1, 10);
        }
    }
    return someArray;
}

int[,] myArray1 = CreateArray(3, 3);
int[,] myArray2 = CreateArray(3, 1);

// Умножение матриц и получение результата
int[,] CreateResultArray(int[,] someArray1, int[,] someArray2)
{
    int[,] resultArray = new int[someArray1.GetLength(0), someArray2.GetLength(1)];
    for (int i = 0; i < someArray1.GetLength(0); i++)
    {
        for (int j = 0; j < someArray2.GetLength(1); j++)
        {
            resultArray[i,j] = 0;
            for (int q = 0; q < someArray1.GetLength(0); q++)
                {
                    resultArray[i, j] +=  someArray1[i, q] * someArray2[q, j];
                }
        }
    }
    return resultArray;
}

int[,] newArray = CreateResultArray(myArray1, myArray2);

// Вывод матрицы
void PrintResultArray(string someString, int[,] someArray)
{
    Console.WriteLine(someString);
    for (int i = 0; i < someArray.GetLength(0); i++)
        {
            for (int j = 0; j < someArray.GetLength(1); j++)
                {
                    Console.Write($"{someArray[i, j]} ");
                }
            Console.WriteLine();
        }
}

PrintResultArray("Матрица 1:", myArray1);
PrintResultArray("Матрица 2:", myArray2);
PrintResultArray("Полученная матрица:", newArray);
