// Задача 1: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// 4 3 1 (1,2) => 9
// 2 6 9

// Console.Write("Введите строку: ");
// int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;
// Console.Write("Введите столбец: ");
// int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;
// int n = 5; 
// int m = 5; 
// Random Random = new Random();
// int[,] matrix = new int[n, m];
// Console.WriteLine("Исходный массив: ");

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = Random.Next(0, 101);
//         Console.Write("{0} ", matrix[i, j]);
//     }
// Console.WriteLine();
// }

// if (pos1 < 0 | pos1 > matrix.GetLength(0) - 1 | pos2 < 0 | pos2 > matrix.GetLength(1) - 1)
// {
//     Console.WriteLine("Элемент не существует");
// }

// else
// {
//     Console.WriteLine("Значение элемента массива = {0}", matrix[pos1, pos2]);
// }

// -----------------------------------------------------------------------------------

// Задача 2: Задайте двумерный массив. Напишите
// программу, которая поменяет местами первую и
// последнюю строку массива.
// 4 3 1 => 4 6 2
// 2 6 9    2 6 9
// 4 6 2    4 3 1


// int[,] array = new int[3, 3]
// {   
//     {4, 3, 1},
//     {2, 6, 9},
//     {4, 6, 2},
// };

// for(int i = 0; i < array.GetLength(1); i++)
// {
//     int tmp = array[2, i];
//     array[2, i] = array[0, i];
//     array[0, i] = tmp;
// }

// for(int i = 0; i < array.GetLength(0); i++)
// {
//     for(int j = 0; j < array.GetLength(1); j++)
//     {
//         Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
// }



// -----------------------------------------------------------------------------------

// Задача 3: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с
// наименьшей суммой элементов.
// 4 3 1 => Строка с индексом 0
// 2 6 9
// 4 6 2 


// Console.WriteLine("Введите размер массива m x n и диапазон случайных значений:");
// int m = InputNumbers("Введите m: ");
// int n = InputNumbers("Введите n: ");
// int range = InputNumbers("Введите диапазон: от 1 до ");

// int[,] array = new int[m, n];
// CreateArray(array);
// WriteArray(array);

// int minSumLine = 0;
// int sumLine = SumLineElements(array, 0);
// for (int i = 1; i < array.GetLength(0); i++)
// {
//   int tempSumLine = SumLineElements(array, i);
//   if (sumLine > tempSumLine)
//   {
//     sumLine = tempSumLine;
//     minSumLine = i;
//   }
// }

// Console.WriteLine($"{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");


// int SumLineElements(int[,] array, int i)
// {
//   int sumLine = array[i,0];
//   for (int j = 1; j < array.GetLength(1); j++)
//     sumLine += array[i,j];
//   return sumLine;
// }

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void CreateArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//       array[i, j] = new Random().Next(range);
//   }
// }

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//       Console.Write(array[i,j] + " ");
//     Console.WriteLine();
//   }
// }


// -----------------------------------------------------------------------------------

// Задача 4*(не обязательная): Задайте двумерный массив
// из целых чисел. Напишите программу, которая удалит
// строку и столбец, на пересечении которых расположен
// наименьший элемент массива. Под удалением
// понимается создание нового двумерного массива без
// строки и столбца.
// 4 3 1 => 2 6
// 2 6 9    4 6
// 4 6 2

int[,] matrix = GetMatrix(4, 5, 10, 99);
Print(matrix);
Console.WriteLine();
int row = 0;
int column = 0;
int min = FindMinElement(matrix, out row, out column);
int[,] newMatrix = GetNewMatrix(matrix, row, column);
Print (newMatrix);

Console.WriteLine(row);

int[,] GetMatrix(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = rand.Next(minValue, maxValue + 1);
        }
    }
    return result;
}

int FindMinElement(int[,] matrix, out int row, out int column)
{
    int min = matrix[0, 0];
    row = 0;
    column = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(min > matrix[i,j])
            {
            row = i;
            column = j;
            min = matrix[i, j];
            }
        }
    }
    return min;
}

int[,] GetNewMatrix(int[,] matrix, int row, int column)
{
    int[,] newMatrix = new int [matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int newIndexRow = 0;
    int newIndexColumn = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i != row)
        newIndexRow = 0;
        {
             for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if(i != column)
                {
                    newMatrix[newIndexRow, newIndexColumn] = matrix[i, j];
                    newIndexColumn++;
                }
            }
        }
        newIndexRow++;
    }
}
return newMatrix;

void Print(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        Console.WriteLine();
        }
    }
}