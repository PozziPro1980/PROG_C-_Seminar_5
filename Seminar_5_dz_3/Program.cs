// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и
//  минимальным элементов массива.

// [3 7 22 2 78] -> 76

int max = Int32.MinValue;
int min = Int32.MaxValue;

int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(10,100);
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return array;
}
int[] array = GetArray(10);

Console.WriteLine(String.Join(", ",array));

Console.WriteLine("Максимальное число: " +max);
Console.WriteLine("Минимальное число: " +min);
Console.WriteLine("Разница: " +(max-min));