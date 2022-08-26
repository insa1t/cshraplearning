Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

if (num%2 == 0) Console.WriteLine($"Число {num} является четным");
else Console.WriteLine($"Число {num} является нечетным");