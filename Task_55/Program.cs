/*
    Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
    В случае, если это невозможно, программа должна вывести сообщение для пользователя.
*/

Console.Clear();
//================================Методы===========================================================
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

//проверка чтобы совпaдали строки и столбцы
bool ValidColumnAndRows(int[,] arr) => arr.GetLength(0) == arr.GetLength(1);

///Меняем местами строки на столбцы
void SwapColumAndRows(int[,] arr)
{
    int[,] dublikateArr = new int[arr.GetLength(0), arr.GetLength(1)];

    for(int i = 0; i <  dublikateArr.GetLength(0);i++)
    {
        for(int j = 0;j < dublikateArr.GetLength(1); j++)
        {
            dublikateArr[i, j] = arr[i, j];
        }
    }

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = dublikateArr[j, i];
        }
    }
}
//==================================================================================================
//Ввод размера
int rowSize = EnterMesseng("Введите количество строк :");
int colSize = EnterMesseng("Введите количество столбцов :");

//Создание массива
int[,] array = CreateArray(colSize, rowSize);

//Проверяем на равенство строки и столбцы
if (ValidColumnAndRows(array))
{

    //Заполняем рандомными числами
    FillRandomArray(array);
 
    Console.WriteLine();

    PrintArray(array);

    Console.WriteLine();

    SwapColumAndRows(array);

    Console.WriteLine();

    PrintArray(array);
}
else
{
    Console.WriteLine("Error, please try agayn !");
}
