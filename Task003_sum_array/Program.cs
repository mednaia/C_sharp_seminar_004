// Найти сумму чисел одномерного массива стоящих на нечетной позиции

// Найти сумму чисел одномерного массива стоящих на нечетной позиции
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

void SumOdd(int[] array)
{
    int count = array.Length;
    int sum = 0;
    for(int i = 0; i < count; i++)
    {
        if (i == 1 || i%2 == 1)
        sum = sum + array[i];
    }
    Console.Write($"{sum} ");
}

int[] array = new int[6];

FillArray(array);
PrintArray(array);
Console.WriteLine();
SumOdd(array);