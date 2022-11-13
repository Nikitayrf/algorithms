// Найти в массиве 2 - е максимальное число.

Console.Write("Введите сколько чисел будет в массиве : ");

int elementsCounts = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[elementsCounts];

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"Введите {i + 1}-е число массива : ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

int firstMaxNumber = numbers[0];
int secondMaxNumber = numbers[0];

if (numbers[1] > firstMaxNumber)
{
    firstMaxNumber = numbers[1];
}
else
{
    secondMaxNumber = numbers[1];
}

for (int current_index = 2; current_index < numbers.Length; current_index++) {
    if (numbers[current_index] > firstMaxNumber) {
            secondMaxNumber = firstMaxNumber;
            firstMaxNumber = numbers[current_index];
        }
    else if (numbers[current_index] > secondMaxNumber) {
            secondMaxNumber = numbers[current_index];
        }
    else current_index++;
}

Console.WriteLine($"Второе максимальное число в массиве равно : {secondMaxNumber}");
