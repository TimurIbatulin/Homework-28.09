﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Write("Введите число, которое нужно возвести в степень - ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение степени для числа - ");
int i = Convert.ToInt32(Console.ReadLine());
int F=a;
int n=2;
while (n<=i)
//for (int N = 2; N<=i; N++); с этим циклом не считало, я не нашел ошибку
//{
//    F=F*a;
//}
{
    F=F*a;
    n++;
}
Console.Write($"{a} возведенное в степень {i} равно {F}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]