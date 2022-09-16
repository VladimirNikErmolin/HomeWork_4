// Цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите через пробел числа А и В:");
string AB = Console.ReadLine()!;
string[] numbers = AB.Split(' ');
int A = int.Parse(numbers[0]);
int B = int.Parse(numbers[1]);

ToPower(A, B);
Console.WriteLine($"Число {A} в степени {B} равно {ToPower(A, B)}");


int ToPower(int arg1, int arg2)
{
    int power = 1;
    for (int i = 1; i <= arg2; i++)
    {
        power *= arg1;
    }
    return power;
}