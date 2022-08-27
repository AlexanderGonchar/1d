//Задача 5

Console.Write("Введите 1 число : ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите 2 число: ");
int m = int.Parse(Console.ReadLine());
for (int i = n; i <= m; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}
Console.ReadKey();


