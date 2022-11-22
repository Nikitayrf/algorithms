// Посчитать количество положительных чисел в произвольно заданном массиве.

void someArray(int[] argument) // метод генерирует массив случайных чисел (-10, 10)

{
    for (int i = 0; i < argument.Length; i++)
    {
        argument[i] = new Random().Next(-10, 10);
    }
}

void printArray(int[] col) // метод вывод к консоль массив
{
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write($"{col[i]} ");
    }
}

void positivNum(int[] array) // метод считает кол-во положительных чисел в массиве
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        } 
    }
    Console.WriteLine($"\nКолличество положительных символов равно : {count}");
}

int[] array = new int[10];

someArray(array);
printArray(array);
positivNum(array);


