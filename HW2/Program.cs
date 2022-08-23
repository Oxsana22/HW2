// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите целое число, a = ");
int a = Convert.ToInt32( Console.ReadLine()  );
 
Console.Write("Введите целое число, b = ");
int b = Convert.ToInt32( Console.ReadLine()  );

Console.Write("Введите целое число, c = ");
int c = Convert.ToInt32( Console.ReadLine()  );

int max=a;

if (a>max) max=a;
if (b>max) max=b;
if (c>max) max=c;

Console.Write("max= ");
Console.WriteLine(max);






// Console.Write("Введите целое число, a = ");
// int a = Convert.ToInt32( Console.ReadLine()  );
// Console.Write("Введите целое число отличное от числа (a), b = ");
// int b = Convert.ToInt32( Console.ReadLine()  );

// if (a>b)
// {
//     Console.WriteLine("max = " + a );
// }
// else
// {
//     Console.WriteLine("max = " + b );
// }