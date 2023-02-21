// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
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
}
int line = ReadInt("Введите колличество строк массива: ");
int column = ReadInt("Введите колличество столбцов массива: ");
int[,] numbers = new int[line, column];
FillArray(numbers, 0, 2);
PrintArray(numbers);
for (int i = 0; i < numbers.GetLength(1); i++)
{
    int sum = 0;
    for (int j = 0; j < numbers.GetLength(0); j++)
    {
        sum = (sum + numbers[j, i]);
    }
    Console.WriteLine($"Среднее арифметическое 'Элементов {i + 1} столбца равно {(double)sum / numbers.GetLength(0)}");
}
