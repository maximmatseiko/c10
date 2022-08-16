// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

void ArrayRandomNumbers(int[,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int z = 0; z < array.GetLength(1); z++)
        {
            array[a, z] = new Random().Next(1, 15); 
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
            Console.Write(array[i, j] + " ; ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

int size = InputInt("размерность матриц: ");
int[,] matrixA = new int[size, size];
int[,] matrixB = new int[size, size];
ArrayRandomNumbers(matrixA);
ArrayRandomNumbers(matrixB);
int[,] matrixC = new int[size, size];

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
        }
    }
}
Console.WriteLine("Матрица - А");
PrintArray(matrixA);
Console.WriteLine();
Console.WriteLine("Матрица - В");
PrintArray(matrixB);
Console.WriteLine();
Console.WriteLine("Произведение матриц А*В");
PrintArray(matrixC);
