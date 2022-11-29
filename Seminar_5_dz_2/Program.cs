// Задача 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int sum = 0;
int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1,10);
        if (i % 2==0)
        {
            sum +=array[i];
        }
    }
    return array;
}
int[] array = GetArray(4);

Console.WriteLine(String.Join(", ",array));

Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: " +sum);