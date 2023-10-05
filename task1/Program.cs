// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int itog = 1;
Console.WriteLine("Введите число 1: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int B = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < B; i++){
    itog *= A;
}
Console.WriteLine(itog);
