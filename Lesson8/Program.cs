//Seminar 8
// Задача: Задайте двумерный массив. Напишите программу, которая поменяет местами строки массива.

 int[,] CreateRandom2Array(int rows, int columns, int minValue, int maxValue) //Метод заполнения 2d массива случайными числами. 
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue,maxValue + 1);
        
    return array;
}


void Show2Array(int[,] array) //Метод выводв 2D массива
{
    for(int i = 0; i < array.GetLength(0); i++)
    {   for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
     
}
/*
void ChangRow(int[,] array, int row1,int row2) //Метод замены любых строк
{
    if (row1 >= 0 && row1 < array.GetLength(0) && 
        row2 >= 0 && row2 < array.GetLength(0) && 
        row1 != row2)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[row1,j];
            array[row1,j] = array[row2,j];
            array[row2,j] = temp;    
        }
    }
    else Console.WriteLine("Incorrect rows for changing!");
}

Console.Clear();

Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of column: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min possible value:");
int minV = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value:");
int maxV = Convert.ToInt32(Console.ReadLine());

int [,] myArray = CreateRandom2Array(m, n, minV, maxV);
Show2Array(myArray);

Console.WriteLine();
Console.Write("Input a number row1:");
int r1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Input a number row2:");
int r2 = Convert.ToInt32(Console.ReadLine()) - 1;
ChangRow(myArray, r1, r2);
Show2Array(myArray);
*/
//Задача: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
/*
void TransposeArray(int[,] array)
{
    if (array.GetLength(0) == array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = i + 1 ; j < array.GetLength(1); j++)
            {
               int temp = array[i,j];
                array[i,j] = array[j,i];
                array[j,i] = temp;   
            }
    
        
    }
    else Console.WriteLine("Array is not square!");
}
Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of column: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min possible value:");
int minV = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value:");
int maxV = Convert.ToInt32(Console.ReadLine());

int [,] myArray = CreateRandom2Array(m, n, minV, maxV);
Show2Array(myArray);

Console.WriteLine();
TransposeArray(myArray);
Show2Array(myArray);
*/


//Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
int[,] DeleteRowColumnMinElement(int[,] array)
{
    int minI = 0;
    int minJ = 0;
    int min = array[0,0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] < min)
            {
                min = array[i,j];
                minI = i;
                minJ = j;
            }
        }
        
    }
    int[,] newArray = new int [array.GetLength(0)-1,array.GetLength(1)-1];
 
    for (int i = 0, x = 0; i < array.GetLength(0); i++, x++) 
    {   
        if (i != minI)
            for (int j = 0, y = 0; j < array.GetLength(1); j++, y++)
                {
                    if (j != minJ) 
                        newArray[x,y] = array[i,j];
                    else y --;
                }   
        else  x --;
        
    }
    return newArray;
}
Console.Clear();

Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of column: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min possible value:");
int minV = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value:");
int maxV = Convert.ToInt32(Console.ReadLine());

int [,] myArray = CreateRandom2Array(m, n, minV, maxV);
Show2Array(myArray);
Console.WriteLine();
Show2Array(DeleteRowColumnMinElement(myArray));
