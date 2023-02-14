// Задача 56. Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 10); 
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]}\t");
        Console.WriteLine();
    }
}

int ReleaseMatrix(int[,] matrix)
{
    int minRow = 0;
    for (int k = 0; k < matrix.GetLength(1); k++)
        minRow += matrix[0, k];

    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int sumRow = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRow += matrix[i, j];
                     
        }
        if (minRow > sumRow)
            minRow = sumRow;
           
    }
    return minRow;
   // Console.WriteLine($"Сумма эл-тов мин строки  = {minRow}");

}

Console.Clear();
Console.Write("Введите размеры прямоугольного массива: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
if (size[0] == size[1])
{
    Console.Write("Вы ошиблись!\nВведите размер прямоугольного двумерного массива: ");
    size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Начальный двумерный массив: ");
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine($"Результат: {ReleaseMatrix(matrix)}");
//ReleaseMatrix(matrix);
