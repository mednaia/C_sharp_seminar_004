// Найти сумму чисел одномерного массива стоящих на нечетной позиции
int[]array = new int[8];
for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(-10,11);
int sum = 0;
for(int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
for (int i = 1; i < array.Length; i = i+2) 
{
    sum+=array[i];
}
Console.WriteLine();
Console.WriteLine($"The sum of odd-elemets in array = {sum} ");