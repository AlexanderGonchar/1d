Console.Write("Введите первое число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое число b: ");
int b = Convert.ToInt32(Console.ReadLine());

int result = a / b;
if (a % b == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    System.Console.WriteLine("Остаток = " + a % b);

}

