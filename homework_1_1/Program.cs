﻿Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
if(a > b) max = a;
else max = b;
Console.Write("max = ");
Console.Write(max);