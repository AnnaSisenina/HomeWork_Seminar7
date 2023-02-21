// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
int ReadInt(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
void FillArray(int[,] array, int from, int to)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(from, to);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void OrderArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                int max = array[i, j];
                int index = j;
                for (int k = j+1; k < array.GetLength(1); k++)
                {
                    if (array[i, k] > max) 
                    {
                        max=array[i, k];
                        index = k;
                    }
                }
                array[i, index] = array[i, j];
                array[i, j] = max;
            }
        }
    }
}

int line = ReadInt("Введите колличество строк массива: ");
int column = ReadInt("Введите колличество столбцов массива: ");
int[,] numbers = new int[line, column];
FillArray(numbers, 0, 10);
PrintArray(numbers);
OrderArray(numbers);
PrintArray(numbers);