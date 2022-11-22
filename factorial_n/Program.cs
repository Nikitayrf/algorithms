// Метод вычисления факториала n!.

Console.Write("Введите целое положительное число факториал которого вы хотите найти : ");
int number = Convert.ToInt32(Console.ReadLine());

int factorialN(int num)
{
    int factorial = 1;
    for (int i = 1; i <= num; i++)
    {
        factorial = factorial * i;
    }
    Console.WriteLine($"Факториал равен : {factorial}");
    return factorial;
    
}

factorialN(number);


