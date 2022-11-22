// Сделать "разворот" массива. Нужно перевернуть массив и записать его в обратном порядке.

void PrintArray(int[] col) // Метод печати массива
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}

int[] array = {1, 2, 3, 4, 5};

void ReversArray(int[] col) // Разворот для НЕ четного массива 
{
    for (int i = 0; i < col.Length / 2; i++)
    {
        int temp = col[i];
        col[i] = col[col.Length - i - 1];
        col[col.Length - i - 1] = temp;
    }
}

ReversArray(array);
PrintArray(array);
Console.WriteLine();

int[] arrayB = { 2, 4, 6, 8, 9 };

ReversArray(arrayB);
PrintArray(arrayB);