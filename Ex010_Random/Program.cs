﻿// Напишите программу, кот. выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа

/* 23 / 10 = 2 - получаем десятки
   23 % 10 = 3 - единицы */

int number = new Random().Next(10, 100);
int a1 = number % 10;
int a2 = number / 10;

int max = a1;
if (a1 > a2) 
{
    max = a2;
}
Console.Write($"Максимальная цифра = {max} числа {number}");