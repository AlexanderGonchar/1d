Console.Write("Введите первое число n: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 100)
{
    Console.WriteLine("В числе нет третьей цифры");
}
else
{
    Console.Write("Третья цифра в числе: ");
    Console.WriteLine(n % 10);
}