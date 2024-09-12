
// int [,] matrix = new int[3,5]; 
// Random rnd = new Random();
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = rnd.Next(1,1000);
//         Console.Write($"{matrix[i,j]} ");

//         // matrix[i,j] = rnd.Next(1,11);
//     }
//     Console.WriteLine();
// }

// string str = "Hello";
// Console.Write(str[0]);


// string str = Console.ReadLine();
// string result = GetLettersFromString(str);
// Console.WriteLine(result);

// string GetLettersFromString(string s)
// {
//     string letters = "";
//     foreach (char e in s)
//     {
//         if (char.IsAsciiLetter(e) == true)
//         {
//             letters = letters + e;
//         }
//     }
//     return letters;
// }

// task 39 Напишите программу, которая перевернёт одномерный массив.
// Последний элемент будет на первом месте, а первый на последнем, и т. д.

using System;
using static System.Console;

// Clear();
// Write("Введите размер массива:");
// int n = int.Parse(ReadLine());
// int[] array1 = GetArray(n, 1, 10);
// WriteLine(string.Join(" ", array1));

// int[] array2 = ReverseArray1(array1);
// WriteLine(string.Join(" ", array2));

// ReverseArray2(array1);
// WriteLine(string.Join(" ", array1));

// int[] GetArray(int size, int min, int max)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < result.Length; i++)
//     {
//         result[i] = new Random().Next(min, max + 1);
//     }
//     return result;
// }

// int[] ReverseArray1(int[] inArray)
// {
//     int[] result = new int[inArray.Length];
//     for (int i = 0; i < result.Length; i++)
//     {
//         result[i] = inArray[inArray.Length - 1 - i];
//     }
//     return result;
// }

// void ReverseArray2(int[] inArray)
// {
//     for (int i = 0; i < inArray.Length/2; i++)
//     {
//         int k = inArray[i];
//         inArray[i]= inArray[inArray.Length-1-i];
//         inArray[inArray.Length-1-i] = k;

//     }
// }

// task 40 Программа принимает длинны трёх сторон треугольника
// и проверяет, может ли существовать такой треугольник
// Clear();
// Write("Введите стороны треугольника через пробел: ");
// string[] nums = ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
// if(IsTriangle(int.Parse(nums[0]),int.Parse(nums[1]),int.Parse(nums[2])))
// {
//     WriteLine("Треугольник существует.");
// }
// else
// {
//     WriteLine("Треугольник не существует.");
// }


// bool IsTriangle(int a, int b, int c)
// {
//     return ((a+b>c)&(a+c>b)&(b+c>a));
// }

// task 42 Напишите программу, которая преобразует десятичное
// число в двоичное.
// Clear();
// Write("Введите десятичное число:");

// int n = int.Parse(ReadLine());
// Write("Введите систему счисления для перевода:");
// int sys = int.Parse(ReadLine());
// // первый способ - метод "из коробки"
// // string s1 = Convert.ToString(n, 2);
// // WriteLine(s1);
// string s2 = GetDoubleFromDecimal(n,sys);
// WriteLine(s2);
// // второй способ:

// string GetDoubleFromDecimal(int n, int sys)
// {
//     string result = "";
//     string chars = "0123456789ABCDEF";
//     while (n > 0)
//     {
//         int k = n / sys;
//         int ost = n - k * sys;
//         result = chars[ost].ToString() + result;
//         n = n / sys;
//     }
//     return result;
// }

// task 42 Без рекурсии вывдите первые Н чисел Фибоначчи.

// Clear();
// Write("Введите число N:");
// int n = int.Parse(ReadLine());
// PrintNumber(0,1,n);

// void PrintNumber(int a1, int a2, int size)
// {
//     Write($"{a1} {a2} ");
//     for (int i = 0; i < size - 2; i++)
//     {
//         Write($"{a1 + a2} ");
//         int k = a1 + a2;
//         a1 = a2;
//         a2 = k;
//     }
// }

// task 45 Напишите программу, кот. будет создавать копию
// массива с помощью поэлементного копирования

// Clear();
// WriteLine("Введите массив через пробел:");
// int[] array = GetArreyFromString(ReadLine());
// int[] arrayCopy = CopyArray(array);
// WriteLine(string.Join(" ",arrayCopy));

// int[] CopyArray(int[] inArray)
// {
//     int[] result = new int[inArray.Length];
//     for (int i = 0; i < result.Length; i++)
//     {
//         result[i] = inArray[i];
//     }
//     return result;
// }

// int[] GetArreyFromString(string arrayString)
// {
//     string[] nums = arrayString.Split(" ",StringSplitOptions.RemoveEmptyEntries);
//     int[] result = new int[nums.Length];
//     for (int i = 0; i < result.Length; i++)
//     {
//        result[i]=Convert.ToInt32 (nums[i]);
//     }
//     return result;
// }