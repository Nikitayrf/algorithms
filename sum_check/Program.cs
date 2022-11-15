// Вычисление суммы чека

int[] price = {99, 100, 60}; // массив цен на продукты
int[] numberProduct = {2, 3, 1}; // массив колличества того или иного продукта
int numberItems = price.Length; // сколько позиций в чеке, длинна массива
int index = 0;
int sum = 0; // сумма чека

while (index < numberItems)
{
    sum = sum + price[index] * numberProduct[index];
    index++;
}

Console.WriteLine(sum);