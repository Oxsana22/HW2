//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

void PrintDigit()
{
    Console.Write("Введите целое число, a = ");
    int a = Convert.ToInt32( Console.ReadLine()  );
if (a<=99)  Console.Write("Третьей цифры нет "); 
else{
    while (a>999)
    {
        a=a/10;
    }
    Console.Write($"{a%10} ");
    } 
}

PrintDigit();



