// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.//

/*Console.WriteLine("Input number A");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Input number B");
int number2 = int.Parse(Console.ReadLine());
if (number1>number2)
{
    Console.WriteLine("{0} максимальное", number1);
}
else
{  
    Console.WriteLine("{0} максимальное", number2);

}*/




 //Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.//

/*Console.WriteLine("Введите первое число:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int c = int.Parse(Console.ReadLine());
int max = a;
if (b>max) max = b;
if (c>max) max = c;
Console.WriteLine ("{0} максимальное", max);*/


//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).//

/*Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine());
if (a % 2 == 1)
{
Console.WriteLine("нет");
}
else
{
Console.WriteLine("Да");
}*/


//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.//

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int m = 1;
for (int i = m; i <= n; i++)
{
if (i % 2 == 0) 
{
Console.Write(i + " ");
}      
}