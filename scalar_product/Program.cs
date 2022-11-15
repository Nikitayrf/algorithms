// Записать алгоритм нахождения скалярного произведения двух векторов.
// Формула: (a, b) × (c, d) = a × c + b × d

int[] firstVector = { 1, 8 };
int[] secondVector = { 6, 3 };

int size = firstVector.Length;
int scalarProduct = 0;
int index = 0;

while (index < size)
{
    scalarProduct = scalarProduct + firstVector[index] * secondVector[index];
    index++;
}

Console.WriteLine(scalarProduct);