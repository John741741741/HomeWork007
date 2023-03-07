// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = new int[3, 4];
for (int i = 0; i < array.GetLength(0); i++)
{
    System.Console.WriteLine();
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
        System.Console.Write(array[i, j] + "| ");
    }
}

for (int j = 0; j < array.GetLength(1); j++)
{
    double summ=0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        summ += array[i,j];
    }
    System.Console.WriteLine();
    System.Console.Write($"Среднее орифметическое столбца №{j} {summ / array.GetLength(0)}");
}