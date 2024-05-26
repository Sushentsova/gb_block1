// Задача: Написать программу, которая из имеющегося массива 
// строк формирует новый массив из строк, длина которых меньше,
//  либо равна 3 символам. Первоначальный массив можно ввести 
// с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] FillArray()
{
    System.Console.WriteLine("Введите количество элементов массива и нажмите enter");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] arr = new string[size];
    System.Console.WriteLine("Введите элемент массива и нажмите enter");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Console.ReadLine();
    }
    return arr;
}

void PrintArray(string[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i != arrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}

string[] ThreeSymbolsArray(string[] arr)
{
    int count = 0;
    foreach (string item in arr)
    {
        if (item.Length <= 3)
        {
            count++;
        }
    }
    string[] result = new string[count];
    int i = 0;
    foreach (string item in arr)
    {
        if (item.Length <= 3)
        {
            result[i] = item;
            i++;
        }
    }
    return result;
}

string [] userArr = FillArray();
string[] result = ThreeSymbolsArray(userArr);
PrintArray(userArr);
PrintArray(result);