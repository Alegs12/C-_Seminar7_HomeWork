// Семинар 7 ДЗ

int SetNumber(string str)
{
    System.Console.WriteLine(str);
    int num = int.Parse(Console.ReadLine());
    return num;
}

void PrintArrayDouble(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
        System.Console.WriteLine();
}

int[,] GetRandomMatrix(int rows, int column, int maxVal = 100, int minVal = -100)
{
    int[,] matrix = new int[rows, column];
    var random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i,j] = random.Next(minVal, maxVal+1);
        }
    }
return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i,j] + " ");
        }
    System.Console.WriteLine();
    }
}

void PrintMatrixDouble(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i,j] + " ");
        }
    System.Console.WriteLine();
    }
}


double[,] GetRandomMatrixDouble(int rows, int column,  int minVal = -100, int maxVal = 100)
{
    double[,] matrix = new double[rows, column];
    var random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i,j] = Math.Round(random.Next(minVal*10, maxVal*10) * 0.1, 2);
        }
    }
return matrix;
}

void FindNumber(int[,] matrix, int numAsk)
{
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i,j] == numAsk)
            {
                System.Console.WriteLine($"({i}, {j})");
                k++;
                break;
            }
        }

    if (k >0) break;
    } 
if (k == 0) System.Console.WriteLine("Число не найдено");
}

double[] ArithMeanColumn(int[,] matrix)
{
    double[] itog = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                itog[j] += matrix[i,j];
            }
            itog[j] = Math.Round(itog[j] / matrix.GetLength(0), 2);
        } 
return itog;
}

Start();


void Start()
{
    while(true)
    {
        System.Console.WriteLine("Нажмите Enter");
        Console.ReadLine();
        Console.Clear();

        System.Console.WriteLine("Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");
        System.Console.WriteLine("Задача 50. Напишите программу, которая на вход принимает число в двумерном массиве, и возвращает координаты этого элемента или же указание, что такого элемента нет.");
        System.Console.WriteLine("Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
        System.Console.WriteLine("0 - Выход из программы");

        int numberTask = SetNumber("Введите номер задачи и нажмите Enter");

        switch(numberTask)
        {
            case 0: 
            {
                return; 
                break;
            }
            case 47: 
            {
                int m = SetNumber("Введите число m");
                int n = SetNumber("Введите число n");
                double[,] matr = GetRandomMatrixDouble(m, n, -10, 10);
                PrintMatrixDouble(matr);
                break;
            }
            case 50:
            {
               int m = SetNumber("Введите число строк m");
                int n = SetNumber("Введите число столбцов n");
                int num = SetNumber("Введите искомое число");
                int[,] matr = GetRandomMatrix(m, n, 10, 0);
                PrintMatrix(matr);
                FindNumber(matr, 2);
                break;
             }
            case 52:
            {
                int m = SetNumber("Введите число строк m");
                int n = SetNumber("Введите число столбцов n");
                int[,] matr = GetRandomMatrix(m, n, 10, 0);
                PrintMatrix(matr);
                double[] matrItog = ArithMeanColumn(matr);
                PrintArrayDouble(matrItog);
                break;
            }
            default:
            {
                System.Console.WriteLine("Неверный номер");
                break;
            }
                
        }
    }

}