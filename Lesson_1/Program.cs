/**
Console.WriteLine("Введите число: "); 
int number = int.Parse(Console.ReadLine());
int sqr = number * number;
Console.WriteLine($"Квадрат числа {number} равен = {sqr}");
**/

//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
/**
Console.WriteLine("Введите 2 числа");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

if (num1 == Math.Pow(num2, 2)) {
    Console.WriteLine("Первое число является квдаратом второго");
}
else {
    Console.WriteLine("Первое число не является квадратом второго");
} 
**/

//Напишите программу, которая будет выдавать название дня недели по заданному номеру.

    // Console.Write("Введите день недели");
    //                 try
    //                 {
    //                     int a = Convert.ToInt32(Console.ReadLine());
    //                     switch (a)
    //                     {
    //                         case 1: Console.WriteLine("Понедельник");
    //                             break;
    //                         case 2: Console.WriteLine("Вторник");
    //                             break;
    //                         case 3: Console.WriteLine("Среда");
    //                             break;
    //                         case 4: Console.WriteLine("Четверг");
    //                             break;
    //                         case 5: Console.WriteLine("Пятница");
    //                             break;
    //                         case 6: Console.WriteLine("Суббота");
    //                             break;
    //                         case 7: Console.WriteLine("Воскресенье");
    //                             break;
    //                         default:
    //                             Console.WriteLine("Такого номер дня недели нет");
    //                             break;
    //                     }
    //                 }
    //             catch(FormatException e)
    //                 {
    //                     Console.WriteLine(e.Message);
    //                 }
   