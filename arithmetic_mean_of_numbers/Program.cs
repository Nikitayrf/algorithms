// Найти среднее арифметическое введенных чисел

Console.Write("Введите сколько будет чисел : ");

int elementsCounts = Convert.ToInt32(Console.ReadLine());

double[] numbers = new double[elementsCounts];
double result = 0;
for (int i = 0; i < numbers.Length; i++)
{
   Console.Write($"Введите {i + 1}-е число: ");
   numbers[i] = Convert.ToInt32(Console.ReadLine());
   result = numbers[i] + result; 
}
double arithmeticMean = result / numbers.Length;

Console.WriteLine($"Среднеарифметическое равно: {arithmeticMean}");
