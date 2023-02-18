﻿// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите первую сторону треугольника: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую сторону треугольника: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью сторону треугольника: ");
int number3 = Convert.ToInt32(Console.ReadLine());

bool TriangCompare(int num1, int num2, int num3)
{
    return (num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2);
    

}
bool result = TriangCompare(number1, number2, number3);
Console.WriteLine(result  ? "Да" : "Нет");