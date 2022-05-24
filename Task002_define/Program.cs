// Определить, присутствует ли в заданном массиве, некоторое число
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(-10,10);
        index++;
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void searchInArray(int[] array)
{
    Console.WriteLine("Input integer and press Enter: ");
    int searchNumber = int.Parse(Console.ReadLine());
    for (int j = 0; j < array.Length; j++)
        {
            if(array[j] == searchNumber) Console.Write($"The number {searchNumber} is in the array on position {j}. ");;
        }
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();
searchInArray(array);