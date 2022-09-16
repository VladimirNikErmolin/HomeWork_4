// Пользователь вводит 8 чисел. Поместите их в массив и распечатайте.

Console.WriteLine("Введите 8 чисел через пробел");
string numbers = Console.ReadLine()!;
string [] digits = numbers.Split (' ');

PrintArray (CreatArray (8));

int [] CreatArray ( int size)
{
int [] array = new int [size];
for (int i = 0; i < size ; i++)
{
    array [i] = int.Parse(digits [i]);
}
return array;
}

void PrintArray (int[] array)
{
    Console.Write($"Ваш массив [{string.Join(", ", array)}]");
}
