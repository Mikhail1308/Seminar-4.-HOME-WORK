
// Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран. Сделать через функции
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


Console.Write("Введите размер массива: ");
int[] Mass = new int[int.Parse(Console.ReadLine())];

var random = new Random();
for (int i = 0; i < Mass.Length; i++)
{
    Mass[i] = random.Next(0, 100);
}
Console.WriteLine();
Console.Write("Исходный массив: ");
Console.Write("[");
for (int i = 0; i < Mass.Length; i++)

    Console.Write(Mass[i] + " ");

Console.Write("]");
Console.WriteLine();
