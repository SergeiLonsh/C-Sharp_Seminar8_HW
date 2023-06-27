// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.WriteLine("Введите число строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число стобцов: ");
// int colomns = Convert.ToInt32(Console.ReadLine());

// int [,] matrix= new int[rows,colomns];

// // Метод заполняет массив
// void FillingArray()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//          for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j]= new Random().Next(1,10);
//         }
//     }
// }
// // Метод выводит массив
// void PrintArray()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//          for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//            Console.Write(matrix[i,j]+" ");
//         }
//         Console.WriteLine();
//     }
// }


// void ChangeArray(int [,] array)
// {
     
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//          for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int s = 0; s < array.GetLength(1)-1; s++)

//             if (array[i,s] < array[i,s+1])
                 
//             {
//                int temp = array[i,s];
//                 array[i,s] = array[i,s+1];
//                 array[i,s+1] = temp;
//             }
//         }
//     }
//     }

// FillingArray();
// PrintArray();
// ChangeArray(matrix);
// Console.WriteLine("Новый массив");
// PrintArray();
// ________________________________________________________________________________________


// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка

// Console.WriteLine("Введите число строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число стобцов: ");
// int colomns = Convert.ToInt32(Console.ReadLine());

// int [,] matrix= new int[rows,colomns];


// void FillingArray()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//          for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j]= new Random().Next(1,10);
//         }
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//          for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//            Console.Write(matrix[i,j]+" ");
//         }
//         Console.WriteLine();
//     }
// }
// FillingArray();
// PrintArray();

// int SumStringAmount(int[,] array, int i)
// {
// int sum = array[i,0];
// for (int j = 1; j < array.GetLength(1); j++)
// {
// sum += array[i,j];
// }
// return sum;
// }

// int minSum = 1;
// int sum = SumStringAmount(matrix, 0);
// for (int i = 1; i < matrix.GetLength(0); i++)
// {
// if (sum > SumStringAmount(matrix, i))
// {
// sum = SumStringAmount(matrix, i);
// minSum = i+1;
// }
// }

// Console.WriteLine($"Наименьшая сумма элементов в строке: {minSum}");
// _________________________________________________________________________________

// Задача 58: Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


// int a = InputNum("Введите число строк 1-й матрицы: ");
// int b = InputNum("Введите число столбцов 1-й матрицы (и строк 2-й): ");
// int c = InputNum("Введите число столбцов 2-й матрицы: ");
// int range = InputNum("Введите диапазон чисел: от 1 до ");

// int[,] firstArray = new int[a, b];
// CreateArray(firstArray);
// Console.WriteLine($"Первая матрица:");
// PrintArray(firstArray);

// int[,] secondArray = new int[b, c];
// CreateArray(secondArray);
// Console.WriteLine($"Вторая матрица:");
// PrintArray(secondArray);

// int[,] resArray = new int[a,c];

// MultiplyArray(firstArray, secondArray, resArray);
// Console.WriteLine($"Произведение первой и второй матриц:");
// PrintArray(resArray);

// void MultiplyArray(int[,] firstArray, int[,] secondArray, int[,] resArray)
// {
//   for (int i = 0; i < resArray.GetLength(0); i++)
//   {
//     for (int j = 0; j < resArray.GetLength(1); j++)
//     {
//       int sum = 0;
//       for (int m = 0; m < firstArray.GetLength(1); m++)
//       {
//         sum += firstArray[i,m] * secondArray[m,j];
//       }
//       resArray[i,j] = sum;
//     }
//   }
// }

// int InputNum(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void CreateArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(range);
//     }
//   }
// }

// void PrintArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
//   }
// }
// _______________________________________________________________________________


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Console.WriteLine($"\nВведите размер массива X x Y x Z:");
// int x = InputNumbers("Введите количество строк : ");
// int y = InputNumbers("Введите количество столбцов: ");
// int z = InputNumbers("Введите третью размерность Z: ");
// Console.WriteLine($"");

// int[,,] arrayXYZ = new int[x, y, z];
// CreateArray(arrayXYZ);
// PrintArray(arrayXYZ);

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void PrintArray (int[,,] arrayXYZ)
// {
//   for (int i = 0; i < arrayXYZ.GetLength(0); i++)
//   {
//     for (int j = 0; j < arrayXYZ.GetLength(1); j++)
//     {
      
//       for (int k = 0; k < arrayXYZ.GetLength(2); k++)
//       {
//         Console.Write($"{arrayXYZ[i,j,k]} ({i}, {j}, {k})   ");
//       }
//       Console.WriteLine();
//     }
//     Console.WriteLine();
//   }
// }

// void CreateArray(int[,,] arrayXYZ)
// {
//   int[] temp = new int[arrayXYZ.GetLength(0) * arrayXYZ.GetLength(1) * arrayXYZ.GetLength(2)];
  
//   for (int i = 0; i < temp.GetLength(0); i++)
//   {
//     temp[i] = new Random().Next(10, 100);
   
//     if (i >= 1)
//     {
//       for (int j = 0; j < i; j++)
//       {
//         while (temp[i] == temp[j])
//         {
//           temp[i] = new Random().Next(10, 100);
//         }
//       }
//     }
//   }
//   int count = 0; 
//   for (int x = 0; x < arrayXYZ.GetLength(0); x++)
//   {
//     for (int y = 0; y < arrayXYZ.GetLength(1); y++)
//     {
//       for (int z = 0; z < arrayXYZ.GetLength(2); z++)
//       {
//         arrayXYZ[x, y, z] = temp[count];
//         count++;
//       }
//     }
//   }
// }
// _____________________________________________________________________________________

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// int[,] sprlMatrix = new int[4, 4];

// int i = 0;
// int j = 0;
// int temp = 1;

// while (temp <= sprlMatrix.GetLength(0) * sprlMatrix.GetLength(1))
// {
//   sprlMatrix[i, j] = temp;
//   temp++;
//   if (i <= j + 1 && i + j < sprlMatrix.GetLength(1) - 1)
//     j++;
//   else if (i < j && i + j >= sprlMatrix.GetLength(0) - 1)
//     i++;
//   else if (i >= j && i + j > sprlMatrix.GetLength(1) - 1)
//     j--;
//   else
//     i--;
// }

// PrintArray(sprlMatrix);

// void PrintArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       if (array[i,j] / 10 <= 0)
//       Console.Write($" {array[i,j]} ");

//       else Console.Write($"{array[i,j]} ");
//     }
//     Console.WriteLine();
//   }
// }