
void PrintNumbers(int num1, int num2)
{
int x = new Random().Next(10,100); 
for (int i=num1; i<num2+1; i++) Console.Write($"{i}, ");
// for (int i=num1; i<num2+1;i++) Console.Write(i+", ");
Console.WriteLine();
}

PrintNumbers(2,8);
PrintNumbers(1,7);
PrintNumbers(6,12);
