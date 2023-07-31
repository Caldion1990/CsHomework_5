// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] numbers = new int[5];
int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(-10,10);
    Console.Write(numbers[i] + " ");

    if (numbers[i] % 2 != 0)
    {
        sum = sum + numbers[i];
    }
}
Console.WriteLine();
Console.WriteLine($"Сумма нечетных чисел равно: {sum}");

