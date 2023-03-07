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

