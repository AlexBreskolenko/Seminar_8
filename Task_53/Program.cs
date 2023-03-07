//Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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
void PrintArray(int[,] matr)  
{
    for (int i = 0; i < matr.GetLength(0); i++)  
    {
        for (int j = 0; j < matr.GetLength(1); j++)  
        {
            Console.Write($"{matr[i, j]} " + "\t");
        }
        Console.WriteLine();
    }
}
//Меняем местами первую и последнюю строку
string SwapLine(int[,] array)
{
    string str = String.Empty;
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            
        }
    }

}

//Ввод размера
int colSize = EnterMesseng("Введите количество строк :");
int rowSize = EnterMesseng("Введите количество столбцов :");

//Создание массива
int[,] array = CreateArray(colSize, colSize);

//Распечатываем массив
PrintArray(array);