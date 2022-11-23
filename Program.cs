// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] arr1 = { "Hello", "2", "world", ":-)" };
string[] arr2 = { "1234", "1567", "-2", "computer science" };
string[] arr3 = { "Russia", "Denmark", "Kazan" };
int maxWordLength = 3;

string[] GetShortWordArray(string[] array)
{
    int length = array.Length;
    string[] result = new string[length];
    int count = 0;

    for (int i = 0; i < length; i++)
    {
        if (array[i].Length <= maxWordLength)
        {
            result[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref result, count);

    return result;
}

void PrintArray(string[] array)
{
    if (array.Length == 0)
    {
        Console.WriteLine("Array is empty");
    }
    else
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            System.Console.Write(array[i] + ", ");
        }
        System.Console.Write(array[array.Length - 1]);
    }
}

void Start()
{
    while(true)
    {
        Console.ReadLine();
        Console.Clear();

        System.Console.WriteLine("Choose array: ");
        System.Console.WriteLine("Array 1. [“Hello”, “2”, “world”, “:-)”]");
        System.Console.WriteLine("Array 2. [“1234”, “1567”, “-2”, “computer science”]");
        System.Console.WriteLine("Array 3. [“Russia”, “Denmark”, “Kazan”]");
        System.Console.WriteLine("Enter 0 to end");

        int NumTask = int.Parse(Console.ReadLine());
        switch (NumTask)
        {
            case 0: return; break;
            case 1: PrintArray(GetShortWordArray(arr1)); break;
            case 2: PrintArray(GetShortWordArray(arr2)); break;
            case 3: PrintArray(GetShortWordArray(arr3)); break;
            default: System.Console.WriteLine("Enter number of array or 0"); break; 
        }
    }
}

Start();