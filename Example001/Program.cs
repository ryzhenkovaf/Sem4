// Напишите программу, которая принимает на вход число А и выдает сумму чисел от 1 до А

int GetSum(int n){
    int sum = 0;
    for (int i = 1; i <=n; i++)
    sum += i;
    return sum;
}
Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма от 1 до {n} равна {GetSum(n)}");

