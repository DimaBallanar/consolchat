﻿
Console.Write("Please, write your name: ");
var textFromReadLine = Console.ReadLine();
Console.WriteLine($"Hello, {textFromReadLine}");
Console.Write("HOW old are you? ");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"ничего себе ,тебе {age}");
Console.Write("как думаешь,через сколько месяцев ты освоишь язык C#?: ");
int month = Convert.ToInt32(Console.ReadLine());
if (month < 6)
{
    Console.WriteLine($"{month} ? а ты оптимист)");
}
else
{
    Console.WriteLine($"{month} ? я думаю у тебя получится быстрее)");
}
Console.ReadKey(true);