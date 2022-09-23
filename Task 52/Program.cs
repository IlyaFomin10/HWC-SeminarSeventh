// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

double[,] Getarray (int n, int m)
{
    double[,] array = new double [n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
return array;
}

void OutputDisplay (double[,] array)
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

void OutputAverageСolumn (double[,] array)
{
     for (int i = 0; i < array.GetLength(1); i++)
    {
        double average = 0;
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum = sum + array[j, i];
        }
        average = sum / array.GetLength(0);
        Console.Write(average + " ");
    }         
}


Console.WriteLine("Введите количество строк");
int line = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int column = int.Parse(Console.ReadLine());
double[,] array = Getarray (line, column);
OutputDisplay (array);
Console.WriteLine();
OutputAverageСolumn (array);
