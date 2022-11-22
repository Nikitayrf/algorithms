// Найти максимальный и минимальный элемент в массиве и их индексы.

int[] array = {1,21,44,62,17,14,5};

int max = array[0];
int min = array[0];
int imax = 0;
int imin = 0;

for (int i = 1; i<array.Length;i++)
{
    if (array[i] > max)
    {
        max =array[i];
        imax = i;
    }
    else
    {
        if (array[i] < min)
        {
            min = array[i];
            imin = i;
        }
    }
}

Console.WriteLine($"max = {max}, imax =  {imax}, min = {min}, imin = {imin}");
