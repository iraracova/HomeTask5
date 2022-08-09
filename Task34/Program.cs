// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] FillArrayWithRandomNumbers(int size, int LeftRange, int RightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i ++)
    {
        arr[i] = rand.Next(LeftRange, RightRange + 1);
    } 
    return arr;
}

int[] array = FillArrayWithRandomNumbers(5, 100, 999);

Console.WriteLine('[' + string.Join(", ", array) + ']');

int count = 0;

for(int i = 0; i < array.Length; i ++)
{   
    if(array[i] % 2 == 0)
    {
        count += 1;
        i ++;
    }
}

Console.WriteLine($"Количество чётных чисел в массиве: {count}");