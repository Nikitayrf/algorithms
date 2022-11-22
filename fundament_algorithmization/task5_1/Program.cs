// Используя элементы исходного массива X размерностью N, вычислить элементы массива Y по следующей
//  формуле: Yi = 1 / Xi. Определить среднее арифметическое положительных элементов массива Y.

Console.WriteLine("Введите какая будет размерность массива N : ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];

// Заполнение массима array
for (int i = 0; i < array.Length; i++)
{
    array[i] = i;
}

// Вывод массива по элементно в консоль
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{i} ");
}

Console.WriteLine();

double s = 0;
int k = 0;

for (int j = 0; j < array.Length; j++)
{

    double[] arrayY = new double[n];
    if (array[j] != 0)
    {
        arrayY[j] = Math.Round(1 / Convert.ToDouble(array[j]), 2);
    }
    else
    {
        arrayY[j] = 0;
    }
    if (arrayY[j] > 0)
    {
        s = s + arrayY[j];
        k++;
    }
        Console.Write($"{arrayY[j]} ");// 12 Вывод текущего элемента массива

}

if (k != 0)
{
    s = s / k;
}

Console.WriteLine($"\nСумма положительных элементов равна : {s}");