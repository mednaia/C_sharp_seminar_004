// Написать программу замену элементов массива на противоположные
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

int[] array = new int[10];


void ChangeArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]*-1} ");
    }
     Console.WriteLine();
}

FillArray(array);
PrintArray(array);
Console.WriteLine();
ChangeArray(array);
PrintArray(array);