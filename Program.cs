// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

/* 
int [,] Create2dArray () // создание 2х мерного массива
{
    Console.Write ("Input number of rows: ");
    int rows = Convert.ToInt32 (Console.ReadLine());
    Console.Write ("Input number of column: ");
    int columns = Convert.ToInt32 (Console.ReadLine());
    Console.Write ("Input min possible value: ");
    int minValue = Convert.ToInt32 (Console.ReadLine());
    Console.Write ("Input max possible value: ");
    int maxValue = Convert.ToInt32 (Console.ReadLine());

    int [,] createdArray = new int [rows, columns];

    for (int i = 0; i < rows; i++)
        for ( int j = 0; j < columns; j++)
            createdArray [i,j] = new Random().Next(minValue, maxValue + 1);

    return createdArray;
}

void Show2dArray (int [,] array) // вывод 2х мерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for ( int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write (array[i,j] + " ");
        }
        Console.WriteLine ();
    }
    Console.WriteLine ();
}

int [,] MinChangeRow (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1)-1; j++)
        {
            for (int k = j+1; k < array.GetLength(1); k++)
            {
                if (array[i, j] < array[i, k])
            {
                int temp = array[i, j];
                array[i, j] = array[i, k];
                array[i, k] = temp;
            }
            } 
        }
return array;
}

int [,] myArray = Create2dArray();
Show2dArray(myArray);
MinChangeRow (myArray);
Show2dArray(myArray);
 */

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

/* 
int [,] Create2dArray () // создание 2х мерного массива
{
    Console.Write ("Input number of rows: ");
    int rows = Convert.ToInt32 (Console.ReadLine());
    Console.Write ("Input number of column: ");
    int columns = Convert.ToInt32 (Console.ReadLine());
    Console.Write ("Input min possible value: ");
    int minValue = Convert.ToInt32 (Console.ReadLine());
    Console.Write ("Input max possible value: ");
    int maxValue = Convert.ToInt32 (Console.ReadLine());

    int [,] createdArray = new int [rows, columns];

    for (int i = 0; i < rows; i++)
        for ( int j = 0; j < columns; j++)
            createdArray [i,j] = new Random().Next(minValue, maxValue + 1);

    return createdArray;
}

void Show2dArray (int [,] array) // вывод 2х мерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for ( int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write (array[i,j] + " ");
        }
        Console.WriteLine ();
    }
    Console.WriteLine ();
}

void ShowArray (int [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write ($"{array[i]}, ");
    }
    Console.WriteLine("\b\b].");
}

int [] MinSumRow (int [,] array)
{
    int sum = 0;
    int [] arraySum = new int [array.GetLength(0)];
    
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum += array[i, j];
            }
            for (int k = i; k < array.GetLength(0); k++)
                {
                    arraySum [k] = sum;
                }
            sum = 0;
        }
return arraySum;
}

int minIndex (int [] array)
{
    int min = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < array[min])
            {
                min = i;
            }
    }
    return min;
}

int [,] myArray = Create2dArray();
Show2dArray(myArray);
int [] mySumArray = MinSumRow(myArray);
Console.Write("An array with the sums of the elements in each row of a two-dimensional array: ");
ShowArray(mySumArray);
Console.WriteLine();
int minIndexRow = minIndex (mySumArray);
Console.WriteLine($"The row with the smallest sum of elements is {minIndexRow+1}. The smallest sum of elements is {mySumArray[minIndexRow]}.");
 */

// Задача 58:(дополнительно) Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



// Задача 60.(дополнительно) ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

/* 
int [,,] Create3dArray () // создание 3х мерного массива
{
    Console.Write ("Input number of elements in the dimension x: ");
    int x = Convert.ToInt32 (Console.ReadLine());
    Console.Write ("Input number of elements in the dimension y: ");
    int y = Convert.ToInt32 (Console.ReadLine());
    Console.Write ("Input number of elements in the dimension z: ");
    int z = Convert.ToInt32 (Console.ReadLine());

    int [,,] createdArray = new int [x, y, z];

    for (int i = 0; i < x; i++)
        for ( int j = 0; j < y; j++)
            for ( int k = 0; k < z; k++)
            createdArray [i,j,k] = new Random().Next(10, 100);

    return createdArray;
}

void Show3dArray (int [,,] array) // вывод 3х мерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for ( int j = 0; j < array.GetLength(1); j++)
        {
            for ( int  k= 0; k < array.GetLength(2); k++)
            {
            Console.Write ($"{array[i,j,k]} ({i},{j},{k}) ");
            }
        }
        Console.WriteLine ();
    }
    Console.WriteLine ();
}

int [,,] myArray = Create3dArray();
Console.WriteLine ();
Console.WriteLine ($"3Darray with the size {myArray.GetLength(0)} x {myArray.GetLength(1)} x {myArray.GetLength(2)}.");
Show3dArray(myArray);
 */

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


/* int [,] Create2dSpiralArray () // создание 2х мерного массива
{
    Console.Write ("Input number of rows: ");
    int rows = Convert.ToInt32 (Console.ReadLine());
    Console.Write ("Input number of column: ");
    int columns = Convert.ToInt32 (Console.ReadLine());
    Console.WriteLine ();
    
    int [,] createdArray = new int [rows, columns];
    int el = 1;

    for ( int j = 0; j < columns; j++) // заполнение первой строки
    {
        createdArray [0,j] = el;
        el++;
    }
    
    for ( int i = 1; i < rows-1; i++) // заполнение последнего столбца
    {
        createdArray [i,columns-1] = el;
        el++;
    }
    
    for ( int j = columns-1; j > -1; j--) // заполнение последней строки
    {
        createdArray [rows-1,j] = el;
        el++;
    }
    
    for ( int i = rows-2; i > 0; i--) // заполнение первого столбца
    {
        createdArray [i,0] = el;
        el++;
    }

    // начальные индексы элемента массива внутренней незаполненной области
    int k = 1;
    int m = 1;

    while (el < rows*columns)
    {
    // Вложенный цикл останавливается, если следующий элемент массива не равен 0. Элемент, на котором остановился цикл, не заполняется.
    while (createdArray [k,m+1] == 0) // заполнение вправо
        {
        createdArray [k,m] = el;
        el++;
        m++;
        }
    while (createdArray [k+1,m] == 0) // заполнение влево
        {
        createdArray [k,m] = el;
        el++;
        k++;
        }

   while (createdArray [k,m-1] == 0) // заполнение вниз
        {
        createdArray [k,m] = el;
        el++;
        m--;
        }
    
    while (createdArray [k-1,m] == 0) // заполнение вверх
        {
        createdArray [k,m] = el;
        el++;
        k--;
        }
    }

    for (int i = 0; i < rows; i++) // заполнение последнего элемента массива
        for (int j = 0; j < columns; j++)
            if (createdArray [i,j] == 0) 
            {
                createdArray [i,j] = el;
            }
    
    return createdArray;
}

void Show2dArray (int [,] array) // вывод 2х мерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for ( int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write (array[i,j] + " ");
        }
        Console.WriteLine ();
    }
    Console.WriteLine ();
}

int [,] myArray = Create2dSpiralArray();
Show2dArray(myArray);
 */