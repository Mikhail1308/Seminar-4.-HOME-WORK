// Задача 1: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int numberA = ReadInt("Введите число A: ");
int numberB = ReadInt("Введите степень B: ");
DegreeNumber(numberA, numberB);
void DegreeNumber(int A, int B)
{
    int result = 1;
    for (int i = 1; i <= B; i++)
    {
        result = result * A;
    }
    Console.WriteLine($"Число {A}, возведенное в степень {B} равно {result}");
}
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();


