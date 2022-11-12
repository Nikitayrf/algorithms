// Найти индекс максимального элемента в массиве.

Console.Write("Введите сколько будет чисел : ");

int elementsCounts = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[elementsCounts];

for (int i = 0; i < numbers.Length; i++)
{
   Console.Write($"Введите {i + 1}-е число его индекс {i}: ");
   numbers[i] = Convert.ToInt32(Console.ReadLine());
}
int max = numbers[0];
int max_number_index = 0;
int current_index = 0;

for (current_index = 0; current_index < numbers.Length; current_index++)
{
 if (numbers[current_index] > max) 
 {
    max = numbers[current_index];
    max_number_index = current_index;
 }
 current_index++;
}

Console.WriteLine($"Индекс максимального элемента : {max_number_index}");