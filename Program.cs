/* Дано действительное положительное число a и целое неотрицательное число n.
Вычислите an не используя циклы, возведение в степень через ** и функцию math.pow(),
а используя рекуррентное соотношение an=a⋅an-1.
Решение оформите в виде функции power(a, n). */

double Power(double a, int n)
{
if (n == 1) return a;
    return a * Power(a, --n);
}

Console.WriteLine();
Console.Write("Введите основание степени a: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите показатель степени b: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();
double c = Power(a, n);
Console.WriteLine($"{a} в степени {n} = {c}.");
Console.WriteLine();