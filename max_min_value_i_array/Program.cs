// Найти максимальный и минимальный элемент массива и их индексы.

void someArray(int[] argument) // метод генерирует массив случайных чисел (-10, 10)

{
    for (int i = 0; i < argument.Length; i++) 
    {
        argument[i] = new Random().Next(-10, 10);
    }
}

int[] numbers = new int[10];

someArray(numbers);

for (int i = 0; i < numbers.Length; i++) // вывести все значения массива в консоль
{
    Console.Write($"{numbers[i]} ");
}

int max = numbers[0];
int min = numbers[0];
int imax = 0;
int imin = 0;

for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] >  max){
        max = numbers[i];
        imax = i;
    }
    else
    {
        if (numbers[i] < min) {
            min = numbers[i];
            imin = i;
        }
    }
}

Console.WriteLine($"\nimax = {imax}, imin = {imin}, max = {max}, min = {min}");