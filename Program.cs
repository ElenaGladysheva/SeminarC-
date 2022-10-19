// Семинар 1.
/*
// Задача 1. Напишитн программу, которая на вход принимает два числа и проверяет, что первое число  является квадратом второго.

Console.Write ("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int quad2 = n2*n2;

if (n1 == quad2)
    Console.WriteLine ("Yes");
else
    Console.WriteLine ("No");
*/

/*
// Задача 2. На вход одно число (N), а на выходе показываает числа от -N до N

Console.Clear();
Console.Write("Input a positiv number: ");
int n = Convert.ToInt32(Console.ReadLine());
int current = -n;

while (current <= n)
{
    Console.Write(current + " ");
    current++;
}
*/
/*
// Задача 3. Напишите программу, которая принимает на вход трехзначное число и на выходе показывает последнюю цифру числа.


//  31625 % 10 = 5
//  31625 % 100 = 25
//  31625 % 1000 = 625
//  31625 % 10000 = 1625
//  31625 % 100000 = 31625

//  31625 / 10 = 3162
//  31625 / 100 = 316
//  31625 / 1000 = 31
//  31625 / 10000 = 3

//  26458 -> 45    26458 / 10 % 100


 Console.Clear();
 Console.Write("Input a three-digit number: ");
 int num = Convert.ToInt32(Console.ReadLine());

 int result  = num % 10;
 Console.WriteLine($"Lust digit of {num} is {result}");
*/

// Семинар 2
// Задача 1. Написать программу, которая из трехзначного  случайного числа вырезает второе. Пример 346->36.
/*
int CutNumber(int number)
{
    int ed = number % 10;
    int sot = number / 100;
    number = sot * 10 + ed;
    return number;
    }

Console.Clear();

int num = new Random().Next(100,1000);
int result = CutNumber(num);
Console.WriteLine($"New version of a number {num} is {result}");
*/

//Задача 2. На вход случайное двухзначное число, на выход наибольшую цифру числа.
/*

int MaxDigit(int number)
{
    int result;
    int ed = number % 10;
    int des = number / 10;
    if (ed > des) result = ed;
    else result = des;
    return result;
}

Console.Clear();

int num = new Random().Next(10, 99);
int digit = MaxDigit(num);
Console.WriteLine($"В случайно выбранном числе {num} максимальным будет {digit}");

*/
//Задача 3. Вводятся два числа. Проверить, что второе является кратным первому.
/*
bool Multiplicity (int num1, int num2)
{
   if (num2 % num1 == 0) return true;
   else return false;
       
}

Console.Clear();
Console.Write("Input first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool res =  Multiplicity(number1,number2);

Console.WriteLine(res);

*/
//Задача 3. Подаются два числа на ввод. Проверить, что одно число является квадратом другого.
/*
bool Square (int first, int second)
{
    if (first == second*second || second == first*first)
       return true;
    else
       return false;
    
}

Console.Clear();
Console.Write("Input first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
bool res = Square(number1, number2);
Console.WriteLine(res);   
*/  