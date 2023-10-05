// Этап 1: Создание массива 

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
//  Этап 4: Дополнение функции(Создание нового массива)

string[] CreateNewMassive(string[] FirstArray)
{
    int count = 0;
    for (int i = 0; i < FirstArray.Length; i++)
    {
        if (FirstArray[i].Length <= 3)
            count++;
    }
    string[] result = new string[count];
    int index = 0;
    for (int i = 0; i < FirstArray.Length; i++)
    {
        if (FirstArray[i].Length <= 3)
        {
            result[index] = FirstArray[i];
            index++;
        }
    }
    return result;
}

// Основное тело программы
Console.Clear();
Console.WriteLine("Введите количество элементов массива");
int quantity = int.Parse(Console.ReadLine()!);
string[] FirstArray = new string[quantity];
FillArray(FirstArray);
PrintArray(FirstArray);
Console.WriteLine();
PrintArray(CreateNewMassive(FirstArray));





