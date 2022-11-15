// Найти сумму элементов массива с нечетным значением

int[] numbers = { 1, 12, 3, 4, 5, 16, 7, 8, 9 };
int sum = 0;

for (int i = 0; i < numbers.Length; i++){
    if (numbers[i] % 2 == 1){
        sum += numbers[i];
    }
}

Console.WriteLine($"Сумма элементов с нечетным значением равна : {sum}");