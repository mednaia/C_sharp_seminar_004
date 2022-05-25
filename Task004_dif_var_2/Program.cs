// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
int[]array = new int[8];
for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(-10,11);
for(int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
int minPosition = 0;
int maxPosition = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < array[minPosition]) minPosition = i;
    }
for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > array[maxPosition]) maxPosition = i;
    }
Console.WriteLine();
Console.WriteLine($"The maximum elements = {array[maxPosition]} on position number {maxPosition}");
Console.WriteLine($"The minimum elements = {array[minPosition]} on position number {minPosition}");
Console.WriteLine($"The difference between the maximum and minimum elements {array[maxPosition]-array[minPosition]}");
