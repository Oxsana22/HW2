﻿//   Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1



    Console.Write("Введите целое трёхзначное число, a = ");
    int a = Convert.ToInt32( Console.ReadLine()  );
    Console.Write($"{(a%100-a%10)/10} ");

