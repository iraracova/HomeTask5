// Задача 38: Задайте с клавиатуры массив вещественных (double) чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// Задать размер (int) массива с клавиатуры
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());

double [] arr = new double [size];
for(int i = 0; i < arr.Length; i ++)
{
    Console.WriteLine($"Введите элемент массива под индексом {i}: ");
    arr[i] = Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine("Вывод массива: ");

for(int i = 0; i < arr.Length; i ++)
{
    Console.WriteLine(arr[i]);
}

double max = arr[0];

for(int i = 0; i < arr.Length; i ++)
{
    if(arr[i] > max)
    {
        max = arr[i];
        Console.WriteLine($"Максимальный элемент массива: {max}");
    }
}

double min = arr[0];

for(int i = 0; i < arr.Length; i ++)
{
    if(arr[i] < min)
    {
        min = arr[i];
        Console.WriteLine($"Минимальный элемент массива: {min}");
    }
}
double diff = max - min;
Console.WriteLine($"Разница между минимальным и максимальным элементом массива: {diff}");