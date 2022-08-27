/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
(на вход именно поступает позиция элемента, можете разбить на две переменные или 
прописать в одну строку и конвертировать в два числа, 
комментарии в конце семинара по этой задаче) */

Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите позицию строки для поиска: ");
int positionRows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите позицию столбца для поиска: ");
int positionColumns = Convert.ToInt32(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 50);
PrintArray(array);
int count = SearchItemPosition(array, positionRows, positionColumns);

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int SearchItemPosition(int[,] array, int pr, int pc)
{
    int count = 0;
    if (positionRows < array.GetLength(0) && positionColumns < array.GetLength(1))
    {
        count = array[positionRows, positionColumns];
    }
    return count;

}

if (count > 0)
{
    Console.WriteLine($"Числом заданной позиции является: {array[positionRows, positionColumns]} ");
}
else
{
    Console.WriteLine($"Числа заданной позиции не существует");
}
