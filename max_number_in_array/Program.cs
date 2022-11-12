// Нахождение максимального числа в массиве.

Console.Write("Введите сколько чисел будетв массиве : ");

int elementsCounts = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[elementsCounts];

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"Введите {i + 1}-е число массива : ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

int max = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
}

Console.WriteLine($"\nМаксимальное число в массиве равно : {max}");