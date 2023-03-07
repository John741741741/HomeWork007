// Задача 50: Напишите программу, которая на вход принимает значение 
// элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет



Console.WriteLine("Введите число для поиска: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.Write("массив:");
int[,] array = new int[3, 4];
for (int i = 0; i < array.GetLength(0); i++)
{
    Console.WriteLine();
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 11);
        Console.Write(array[i, j] + "\t");
    }
}
bool a = false;
Console.WriteLine("");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] == N)
        {
            a = true;
            Console.WriteLine($"В заданном массиве число {N} находится на позиции [{i}, {j}]");
        }
    }
}
if (a == false)
    Console.Write($"В заданном массиве числа {N} нет");