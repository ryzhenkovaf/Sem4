// // 26 Напишите программу,
//  которая принимает на вход число и выдаёт количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5

//Console.WriteLine("Введите число num: ");
//int num = int.Parse(Console.ReadLine());
//int count = 0;
//while (count < num) {
//    num = num/10;
//    count++;
//}
//Console.Clear();
//Console.WriteLine($"Количество цифр в числе {count}");

int NumDig(int n)
{
    int count = 0;
    while (n > 0)
    {
        n /= 10;
        count++;
    }
    return count;
}
Console.Clear();
Console.Write("Введите число: ");
int s = int.Parse(Console.ReadLine());
Console.WriteLine($"Количество цифр равна {NumDig(s)}");
