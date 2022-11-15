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
// Семинар 3.

/*//Задача 1. Написать программу, которая по заданному номеру четверти покажет диапазон возможных координат точек в этой четверти.
 void ShowRange(int quart)
 {
    if (quart == 1)
         Console.WriteLine("x > 0 and y > 0");
    else if (quart == 2)
         Console.WriteLine("x < 0 and y > 0");
    else if (quart == 3)
         Console.WriteLine("x < 0 and y < 0");
    else if (quart == 4)
         Console.WriteLine("x > 0 and y < 0");
    else if(quart < 1 || quart > 4)
         Console.WriteLine("Wrong number!");
         
 }

 Console.Clear();
 Console.Write("Input a number of quart: ");
 int quartNum = Convert.ToInt32(Console.ReadLine());
 ShowRange(quartNum);
*/
//Задача 2. Подаются координаты точки, которые не могут быть нулевыми, выдается номер четверти, где лежит.
/*
int Quart (int x, int y)
{
    int result = 0;
    if (x > 0 && y > 0)
        result = 1;
    else if (x < 0 && y > 0)
             result = 2;
    else if (x < 0 && y < 0)
             result = 3;
    else if (x > 0 && y < 0)
             result = 4;
    return result;
}
Console.Clear();
Console.Write("Input x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y: ");
int y = Convert.ToInt32(Console.ReadLine());

int result = Quart(x,y);
if (result == 0)
    Console.WriteLine("Wrong values!");
else Console.WriteLine($"The number of Quart is {result}.");
*/

// Задача 3. Принимаем координаты двух точек. Выдается расстояние между точками в 2 D пространстве.
/*
double Distance (double xA, double yA, double xB, double yB)
{
    double result = -1;
    result = Math.Sqrt(Math.Pow((xB-xA),2)+Math.Pow((yB-yA),2));
    result = Math.Round(result,2);
    return result;
}

Console.Clear();
Console.Write("Input xA: ");
double xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input yA: ");
double yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input xB: ");
double xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Input yB: ");
double yB = Convert.ToInt32(Console.ReadLine());
double result = Distance (xA, yA, xB, yB);

Console.WriteLine($"Distance between points A and B is {result}.");

*/

// Задача 4. Принимает на вход некоторое N (int). Bывод квадротов числа от 1 до N.
/*
void SquareN (int n)
{
    int i = 1;
    while (i <= n)
    {
        Console.Write(i*i + " ");
        i++;
    }
}
Console.Clear();
Console.Write("Input N: ");
int inputN = Convert.ToInt32(Console.ReadLine());
SquareN(inputN);
*/
//Семинар 4

// Задача 1. Написать метод, на вход натуральное число, на выход сумма чисел до этого числа.
/*
int SumN(int number)
{
    int sum = 0;
  for(int i = 1; i <= number; i++)
    sum += i;
  
  return sum;
}

Console.Clear();
Console.Write("Input N: ");
int inputN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum of numbers between1 and {inputN} is {SumN(inputN)}");
*/

// Задача 2. на вход число, на выход количесво цифр.
/*int CountDigit(int number)
{
    int digit = 0;
    while(number != 0)
    {
        number = number/10;
        digit ++;
    }
    return digit;
}
Console.Clear();
Console.Write("Input N: ");
int inputN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The count of number in {inputN} is {CountDigit(inputN)}");
*/
// Задача 3/ На вход число. на выход произведение чисел до N включительно.

/*int ProductNum (int number)
{
    int product = 1;
    for(int i = 1; i <= number; i ++)
        product = product*i;
        
    
    return product;
}
Console.Clear();
Console.Write("Input N: ");
int inputN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The product of numbers in {inputN} is {ProductNum(inputN)} .");
*/

//Семинар 5.
/*

int[] CreatArray(int size) //Метод заполнения массива введенными числами
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {  
         Console.Write("Input element of array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
*/
//Задача: Задан массив из 12 элементов от -9 до 9 нужно посчитать сумму все отрицательных элементов
/*
int[] CreatRandomArray(int size, int minValue, int maxValue) //Метод заполнения массива случайными числами
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue,maxValue+1);
    return array;
}

void ShowArray(int[] array) // Метод вывода массива
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int FindNegativeSum(int[] array) //Метод нахождения суммы отрицательных элементов в массиве

{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i] < 0)
            sum += array[i];
    return sum;
}

Console.Write("Input the size of array: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value:");
int minV = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value:");
int maxV = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreatRandomArray(n, minV, maxV);
ShowArray(myArray);

int negativeSum = FindNegativeSum(myArray);
Console.WriteLine("Sum of negative elements is " + negativeSum);
*/

//Задача: Необходимо проверить присутствует ли заданное число в массиве.
/*
bool FindNumberArray(int[] array, int find) //Метод поиска заданных чисел в массиве.
{
    int size = array.Length;
    
    for(int i = 0; i < size; i++)
    {
        if (array[i] == find)
            return true;       
    }
    return false;
}
int[] CreatArray(int size) //Метод заполнения массива введенными числами
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {  
         Console.Write("Input element of array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}


int[] CreatRandomArray(int size, int minValue, int maxValue) //Метод заполнения массива случайными числами
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue,maxValue+1);
    return array;
}

void ShowArray(int[] array) // Метод вывода массива
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Clear();
Console.Write("Input the search number: ");
int findN = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the size of array: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value:");
int minV = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value:");
int maxV = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreatRandomArray(n, minV, maxV);

ShowArray(myArray);
Console.WriteLine(FindNumberArray(myArray, findN));
*/
//задача: Массив из m чисел, которые случайны. Найти количество элементов отрезка от A до B.
/*
int[] CreatRandomArray(int size, int minValue, int maxValue) //Метод заполнения массива случайными числами
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue,maxValue+1);
    return array;
    
}
void ShowArray(int[] array) // Метод вывода массива
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int CountFindAB (int[] array, int a, int b) // Метод подсчета количества чисел из заданногго отрезка в одномерном массиве. 
{   
    int count = 0;
    for(int i = 0; i < array.Length; i++)

        if(array[i] >= a && array[i] <= b)
            count ++;

    return count;
}
Console.Clear();

Console.Write("Input the size of array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value:");
int minV = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value:");
int maxV = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreatRandomArray(m, minV, maxV);

ShowArray(myArray);

Console.Write("Input A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input B: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The amount of elements in [{a},{b}] is {CountFindAB (myArray, a, b)}");

*/
// Задача: Замена элементов массива на отрицательный и наоборот.
/*
int[] CreatRandomArray(int size, int minValue, int maxValue) //Метод заполнения массива случайными числами
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue,maxValue+1);
    return array;
    
}
void ShowArray(int[] array) // Метод вывода массива
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int[] Replace(int[] array) // Метод смены знака в одномерном массиве.
{
    for(int i = 0; i < array.Length; i++)
        array[i] = -1*array[i];
    return array;
}

Console.Clear();

Console.Write("Input the size of array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value:");
int minV = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value:");
int maxV = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreatRandomArray(m, minV, maxV);

ShowArray(myArray);

ShowArray(Replace(myArray));
*/