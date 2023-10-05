﻿// Этап 1: Создание массива 

void FillArray(string[] FirstArray)
{
    for (int i = 0; i < FirstArray.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        FirstArray[i] = Convert.ToString(Console.ReadLine()!);
    }
}

// Этап 2: Печать массива

void PrintArray(string[] FirstArray)
{
    Console.Write("[ ");
    for (int i = 0; i < FirstArray.Length; i++)
    {
        Console.Write($"{FirstArray[i] + " "}");
    }
    Console.Write("]");
    Console.WriteLine();
}

// Этап 3: Проверка длины элементов массива и их запись в новый массив

int CheckLengthFirstArray(string[] FirstArray)
{
    int count = 0;
    for (int i = 0; i < FirstArray.Length; i++)
    {
        if (FirstArray.Length <= 3)
        {
            count++;
        }
    }
    return count;
}

// Основное тело программы
Console.Clear();
Console.WriteLine("Введите количество элементов массива");
int quantity = int.Parse(Console.ReadLine()!);
string[] FirstArray = new string[quantity];
FillArray(FirstArray);
PrintArray(FirstArray);
CheckLengthFirstArray(FirstArray);