// Программ, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Ведите число");
int number = int.Parse(Console.ReadLine());

FindSumDigits(number);

Console.WriteLine($"Сумма цифр числа {number} равна {FindSumDigits(number)}");


int FindSumDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        int digit = number % 10;
        sum += digit;
        number = number / 10;
    }
    return sum;
}
