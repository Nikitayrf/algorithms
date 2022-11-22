// Составить блок-схему алгоритма, вычисляющего значение функции y = a - 2*b, для всех возможных
// комбинаций значений параметров a и b, принадлежащих интервалам 0 <= a <= 2, шаг ha = 1 и
// -2 <= b <= 2, шаг hb = 2, соответственно. Лпределить среднее арифметическое (S) вычеслееных значений y.

Console.WriteLine("Введите начало цикла(an) : ");
int an = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите конец цикла(ak) : ");
int ak = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите шаг цикла(ha) : ");
int ha = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите начало цикла(bn) : ");
int bn = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите конец цикла(bk) : ");
int bk = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите шаг цикла(hb) : ");
int hb = Convert.ToInt32(Console.ReadLine());

int a = an;
int s =0;
int k =0;
int b = bn;
while(a <= ak)
{
    b = bn;

    do{
        
        int y = a - 2 * b;
        Console.WriteLine($"a = {a}, b = {b}, y = {y}");
        s=s+y;
        k++;
        b= b+hb;
        Console.WriteLine($"k = {k}, s = {s}, b в конце цикла = {b}");
        
    }while(b <= bk);
    a = a + ha;
}
s = s / k;
Console.WriteLine(s);