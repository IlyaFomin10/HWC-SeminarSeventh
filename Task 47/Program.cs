// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int[,] Getarray (int n, int m)
{
    int[,] array = new int [n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = new Random().Next(-1000, 1000);
        }
    }
return array;
}

void OutputDisplay (int[,] array)
{
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }        
}


Console.WriteLine("Введите количество строк");
int line = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int column = int.Parse(Console.ReadLine());
int[,] array = Getarray (line, column);
OutputDisplay (array);
