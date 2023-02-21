// В прямоугольной матрице найти строку с наименьшей суммой элементов.
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
int[] SumLinesElements(int[,] array)
{
    int[] sumLinesElements = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        sumLinesElements[i] = sum;
    }
    return sumLinesElements;
}
int Minimum(int[] array)
{
    int minimum = array[0];
    int index = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minimum)
        {
            minimum = array[i];
            index = i;
        }
    }
    return index;
}

int line = ReadInt("Введите колличество строк массива: ");
int column = line * 2;
int[,] numbers = new int[line, column];
FillArray(numbers, 0, 3);
PrintArray(numbers);
int[] sum = SumLinesElements(numbers);
Console.WriteLine($"Строка с наименьшей суммой элементов - {Minimum(sum)}");