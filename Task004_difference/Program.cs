// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
int[]array = new int[8];
for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(-10,11);
for(int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
Console.WriteLine();
Console.WriteLine($"The difference between the maximum and minimum elements {array[array.Length-1]-array[0]}");