// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int min = 100;
int max = 999;

int[] numbers = new int[size];

FillArrayRandomNumbers(numbers);  // заполнение массива размером, указанным пользователем
PrintArray(numbers);   // вывод массива
int result = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        result++;
    }
}

Console.WriteLine($"Чётных чисел в массиве: {result}");










/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19   [-4, -6, 89, 6] -> 0 */

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] numbers = new int[size];

FillArrayRandomNumbers(numbers);  // заполнение массива по данным, указанных пользователем
PrintArray(numbers);  // вывод массива
int result = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (i % 2 != 0)
    {
        result += numbers[i];
    }
}
Console.WriteLine($"Сумма элементов нечетных позиций = {result}");












/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
[3 7 22 2 78] -> 76  */

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] numbers = new int[size];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);

int maxNum = numbers[0];
int minNum = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > maxNum)
    {
        maxNum = numbers[i];
    }
    if (numbers[i] < minNum)
    {
        minNum = numbers[i];
    }
}
Console.WriteLine($"Разница между максимальным и минимальным числом = {maxNum - minNum}");











// Методы
void FillArrayRandomNumbers(int [] array) //Заполнение массива
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
}

void PrintArray(int[] array) //Вывод массива на экран
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}