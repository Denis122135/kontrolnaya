// Этап 1: Создание массива 

void FillArray(string [] FirstArray)
{
    for (int i = 0; i < FirstArray.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1}элемент массива");
        FirstArray[i] = Convert.ToString(Console.ReadLine()!); 
    }
}

Console.Clear();
Console.WriteLine("Введите количество элементов массива");
int quantity = int.Parse(Console.ReadLine()!);
string [] FirstArray = new string[quantity];
FillArray(FirstArray);