// Вывести массив в консоль

Console.Write("Введите сколько чисел будет в массиве : ");

int elementsCounts = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[elementsCounts];

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"Введите {i + 1}-е число массива : ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Вывод массива: \t");

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"{numbers[i]} ");
}