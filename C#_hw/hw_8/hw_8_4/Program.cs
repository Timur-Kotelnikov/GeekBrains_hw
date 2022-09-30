// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Создание массива
int[,,] CreateArray(int amountLines, int amoutColumns, int amountSlices)
{
    Random rnd = new Random();
    HashSet<int> numbersToFillArray = new HashSet<int>();
    while (numbersToFillArray.Count < amountLines*amoutColumns*amountSlices) 
        {
            numbersToFillArray.Add(rnd.Next(0, 50));
        }
    int[] arrayOfNumbersToFillArray = numbersToFillArray.ToArray();
    int indexOfSet = 0;
    int[,,] someArray = new int[amountLines, amoutColumns, amountSlices];
    for (int i = 0; i < amountLines; i++)
    {
        for (int j = 0; j < amoutColumns; j++)
        {
            for (int q = 0; q < amountSlices; q++)
            {
                someArray[i,j,q] = arrayOfNumbersToFillArray[indexOfSet];
                indexOfSet += 1;
            }
        }
    }
    return someArray;
}

int[,,] myArray = CreateArray(2,2,2);

// Вывод массива
void PrintResultArray(string someString, int[,,] someArray)
{
    Console.WriteLine(someString);
    for (int i = 0; i < someArray.GetLength(0); i++)
        {
            for (int j = 0; j < someArray.GetLength(1); j++)
                {
                    for (int q = 0; q < someArray.GetLength(2); q++)
                    {
                        Console.Write($"{someArray[i, j, q]}, ({i},{j},{q}) ");
                    }
                    Console.WriteLine();
                }
        }
}

PrintResultArray("Созданный массив:", myArray);