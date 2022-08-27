Console.Write("Введите трех значное число : ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Вторая (с начала) цифра : {0}", number.ToString().ToCharArray()[1]);
