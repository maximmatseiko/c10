//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Console.Write("Введите количество строк :");
int numberlines = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов :");
int numbercolumns = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[numberlines, numbercolumns];
ArrayRandomNumbers(numbers);
Console.WriteLine();
Console.WriteLine("Массив до изменения");
PrintArray(numbers);

for (int a = 0; a < numbers.GetLength(0); a++)
{
    for (int s = 0; s < numbers.GetLength(1) - 1; s++)
    {
        for (int x = 0; x < numbers.GetLength(1) - 1; x++)
        {
            if (numbers[a, x] > numbers[a, x + 1]) 
            {
                int temp = 0;
                temp = numbers[a, x];
                numbers[a, x] = numbers[a, x + 1];
                numbers[a, x + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Массив после изменения");
PrintArray(numbers);

void ArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 100);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ;");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
