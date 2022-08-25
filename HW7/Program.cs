// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет 

void PrintDigit()
{
    Console.Write("Давайте проверим выходной ли сегодня день. Введите день недели цифрой, ");
    int x = Convert.ToInt32( Console.ReadLine()  )   ;
    if (x==1)
    {
        Console.WriteLine ("НЕТ");  
    }
    else if (x==3)
    {
        Console.WriteLine ("НЕТ"); 
    }
    else if (x==2)
    {
        Console.WriteLine ("НЕТ"); 
    }
    else if (x==4)
    {
        Console.WriteLine ("НЕТ"); 
    }
    else if (x==5)
    {
        Console.WriteLine ("НЕТ"); 
    }
    else if (x==6)
    {
        Console.WriteLine ("ДА!"); 
    }
    else if (x==7)
    {
        Console.WriteLine ("ДА!"); 
    }
    else 
        Console.WriteLine ();

}
PrintDigit();