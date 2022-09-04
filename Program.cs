// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int Fun()
{
    Console.Clear();
    Console.WriteLine("Введите число ''А'': ");
    int А = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("Введите число ''В'': ");
    int B = Convert.ToInt32(Console.ReadLine());
    int Count = А;

    for (int i = 1; i < B; i++)
    {
        Count = Count * А;
    }
    return Count;
    }

try
{
    Console.WriteLine($"A в степени B равно: {Fun()}");
}
catch
{
    Console.WriteLine("Необходимо вводить числа");
}