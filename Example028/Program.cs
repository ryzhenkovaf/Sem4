//28 Напишите программу, которая принимает на вход число N 
//и выдаёт произведение чисел от 1 до N.

//4-> 24
//5-> 120 == 1 * 2 * 3 * 4 * 5

int GetMultiply(int n)
{
    int result = 1;
    for (int i = 2; i <= n; i++)
    {
        result *=i;
    }
    return result;
}
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Произведение цифр равно {GetMultiply(num)}");
