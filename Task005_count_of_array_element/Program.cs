// Посчитать количество вхождений элемента в массив
int[]array = new int[8];
for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(-10,11);
for(int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
Console.WriteLine();
Console.WriteLine("Input integer and press Enter: ");
    int searchNumber = int.Parse(Console.ReadLine());
    int count =0;
    for (int i = 0; i < array.Length; i++)
        {
            if(array[i] == searchNumber)
            {
                count++;
            }
        }
Console.WriteLine($"The number {searchNumber} is found in array {count} times.");
