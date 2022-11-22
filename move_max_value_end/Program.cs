// "Перенести" максимальное значение в массиве в конец. (Пузырьковая сортировка)

int[] numbers = { 1, 3, -3, -4, 5, 9, 6, -3, 8, -1 };


for (int i = 0; i < numbers.Length; i++)
{
    int temp;
    for (int j = 0; j < numbers.Length - 1 - i; j++)
        if (numbers[j] > numbers[j + 1])
        {
            temp = numbers[j];
            numbers[j] = numbers[j + 1];
            numbers[j + 1] = temp;
        }
}

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"{numbers[i]} ");
}
