// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int[] array = FillArrayWithRandomNumbers(10, 0, 30);

Console.WriteLine('[' + string.Join(", ", array) + ']');

int sum = 0;

for( int i = 1; i < array.Length; i = i + 2)
{
    sum = sum + array[i];
}

Console.WriteLine($"Сумма элементов,стоящих на нечётных позициях : {sum}");