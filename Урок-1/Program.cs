// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int max = 0;
int min = 0;

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber > secondNumber)
{
    max = firstNumber;
    min = secondNumber;
}
else
{
    max = secondNumber;
    min = firstNumber;
}
Console.WriteLine("max = " + max + " и " + "min = " + min);


// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int Max = 0;

Console.Write("Введите первое число: ");
int FirstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int SecondNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int ThirdNumber = Convert.ToInt32(Console.ReadLine());

if(FirstNumber > Max)
{
    Max = FirstNumber;
}
if(SecondNumber > Max)
{
    Max = SecondNumber;
}
if(ThirdNumber > Max)
{
    Max = ThirdNumber;
}

Console.WriteLine("Max = " + Max);


// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int remDiv = number % 2;

if(remDiv == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}


 // Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());

int EvenNumber = 2;

if(number > 1)
{
    while(EvenNumber <= Number)
    {
        Console.Write(EvenNumber + " ");
        EvenNumber = EvenNumber + 2;
    }
}