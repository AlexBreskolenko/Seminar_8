//Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
Console.Clear();

//Ввод числа
int EnterMesseng(string messeng)
{
    Console.WriteLine(messeng);
    int num = int.Parse(Console.ReadLine());
    return num;
}

//Создаём размер массива
var CreateArray = (int sizeCol, int sizeRow) => new int[sizeCol, sizeRow];

// метод для печати двумерного массива
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
//Меняем местами первую и последнюю строку
void SwapLine(int[,] array)
{
    int[] arr_1 = new int[array.GetLength(1)];
    int[] arr_2 = new int[array.GetLength(1)];

    for (int i = 0; i < array.GetLength(1); i++)
    {
        arr_1[i] = array[0, i];
        arr_2[i] = array[array.GetLength(0) - 1, i];
    }

    for (int i = 0; i < array.GetLength(1); i++)
    {
        array[0, i] = arr_2[i];
        array[array.GetLength(0) - 1, i] = arr_1[i];
    }

}

//Заполняем массив рандомными числами
void FillRandomArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

//Ввод размера
int colSize = EnterMesseng("Введите количество строк :");
int rowSize = EnterMesseng("Введите количество столбцов :");

//Создание массива
int[,] array = CreateArray(colSize, rowSize);

//Заполняем рандомными числами
FillRandomArray(array);

//Распечатываем массив
PrintArray(array);

Console.WriteLine();

SwapLine(array);

PrintArray(array);