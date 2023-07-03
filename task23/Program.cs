// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
while (n<1) {
    Console.Write("Введите число больше ноля: ");
    n = int.Parse(Console.ReadLine());
}
for (int i=1; i <= n; i++)
    Console.Write($"{i*i*i} ");