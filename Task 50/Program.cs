// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] Getarray (int n, int m)
{
    int[,] array = new int [n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = new Random().Next(0, 20);
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

void CheckNumber (int[,] array, int number)
{
    int no = 0;
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                Console.WriteLine($"Элемент под индексом [{i}, {j}] имеет значение - {number}");
            }
            else no = no + 1;
        }
    }    
        if (no == (array.GetLength(0) * array.GetLength(1)))
        {
            Console.WriteLine("Введенного вами числа нет в массиве");
        }      
}



Console.WriteLine("Введите количество строк");
int line = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int column = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число которое хотите проверить в массиве");
int number = int.Parse(Console.ReadLine());
int[,] array = Getarray (line, column);
OutputDisplay (array);
CheckNumber (array, number);