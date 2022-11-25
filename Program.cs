// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. a = 5; b = 7 -> max = 7 a = 2 b = 10 -> max = 10 a = -9 b = -3 -> max = -3//
/*Console.WriteLine("Введите первое чило:");
int num_A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе чило:");
int num_B = Convert.ToInt32(Console.ReadLine());
if (num_A > num_B)
{
    Console.WriteLine("Первое число" + num_A + "больше чем второе" + num_B );
}
else
{
    Console.WriteLine("Второе число"  + num_B +  "больше чем первое"  + num_A );
}*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*Console.WriteLine ("Введите три числа:");
int num_1 = Convert.ToInt32(Console.ReadLine());
int num_2 = Convert.ToInt32(Console.ReadLine());
int num_3 = Convert.ToInt32(Console.ReadLine());

int max = num_1;
if (num_2 > max)
{
    max = num_2;
}
if (num_3 > max)
{
    max = num_3;
}
Console.WriteLine("Наибольшее из введенных чисел ->" + max );*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*Console.WriteLine ("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 1)
{
    Console.WriteLine("Число" + num + "является нечетным");
}
else
{
    Console.WriteLine("Число" + num + "является четным");
}*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*int N = int.Parse(Console.ReadLine());
int i = 1, k = 1;            
while (true)
{
	if (i % 2 == 0)
	{
		Console.Write(i + " ");
		k++;
	}
	if (k > N)
	{
		break;
	}
	i++;
}*/