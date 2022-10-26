// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
//m = 3, n = 4.

/*
Console.WriteLine("Введите число строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число колонок: ");
int columns = int.Parse(Console.ReadLine()!);


void PrintDoubleArray (double[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
Console.WriteLine($"{array[i,j]}");
}
}
Console.WriteLine();
}


double[,] GetArrayDouble(int rows, int columns, int minValue, int maxValue)
{
    double [,] result = new double[rows,columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++){
            result[i,j] = Math.Round(new Random().NextDouble() * new Random).Next(minValue, maxValue);
        }
    }
    return result;  
}
*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

/*
Console.WriteLine("Введите число строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число колонок: ");
int columns = int.Parse(Console.ReadLine()!);

void GetElementInArray(int[,] array, int rowNumber, int columnNumber)
{
    if (rowNumber <= array.GetLength(0)
        && rowNumber > 0
        && columnNumber <= array.GetLength(1)
        && columnNumber > 0)
    { Console.WriteLine($"Число cross {rowNumber} и {columnNumber} находится: {array[rowNumber - 1, columnNumber - 1]}"); }
    else { Console.WriteLine($"В массиве строк: {array.GetLength(0)}, количество столбцов: {array.GetLength(1)}, вне массива"); }
}

int[,] GetArrayElement(int rows, int columns, int minValue, int maxValue){
    for (int i = 0; i < rows; i++){
        for (int j = 0; j < columns; j++){
            result[i,j] = new Random().Next(minValue, maxValue +1);
        }
    } 
    return result;
}
*/

//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
/*
Console.WriteLine("Введите число строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число колонок: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray (rows, columns, 4,3);
PrintArray(array);

int[,] GetArray (int rows, int columns, int minValue, int maxValue){
    int result = new int[rows,columns];
    for (int i = 0; i < rows; i++){
        for (int j = 0; j < columns; j++){
            result[i;j] = new Random().Next(minValue,maxValue + 1);
        }
    }
    return result;
}

void GetAverageColumns (int[,] array){
    for (int j = 0; j < array.GetLength; j++){
        double sum = 0;
        double average = 0;
        for (int i = 0; i < array.GetLength; i++)
        {
sum = array[i,j];
        }
        average = Math.Round(sum/array.GetLenght(0,1));
        Console.WriteLine($"Среднее арифметическое в столбце {j+1}: {average}");
    }
}
*/
