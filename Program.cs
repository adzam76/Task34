// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] numbers = new int[4];
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(100, 999);
}
int result = 0;
for (int n = 0; n < numbers.Length; n++)
{
    if (numbers[n] % 2 == 0)
        result++;
}
Console.WriteLine(string.Join(" ,  ", numbers));
Console.WriteLine($"из {numbers.Length} чисел, {result} четных");