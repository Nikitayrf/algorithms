// "Перенести" максимальное значение в массиве в конец. (Сортировка выбором)

int[] numbers = { 9, 67, -86, 0, 5, 9, 52, 9, 10, -34, 4, 18, -3 };

Console.WriteLine("Заданный массив равен : ");
for (int i =0; i < numbers.Length; i ++)
{
    Console.Write($"{numbers[i]} ");
}

int min;
int temp;
for (int i =0; i<numbers.Length;i++){
    min = i;
    for (int j = i+1; j < numbers.Length; j++)
    {
        if (numbers[j] < numbers[min]){
            min =j;
        }
    }
    temp = numbers[min];
    numbers[min] = numbers[i];
    numbers[i] = temp;
}
Console.WriteLine("\n\nОтсартированный массив равен : ");
for (int i =0; i < numbers.Length; i ++)
{
    Console.Write($"{numbers[i]} ");
}