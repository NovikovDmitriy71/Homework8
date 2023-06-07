// //двумерный массив, упорядочить по убыванию элементы каждой строки

// int[,] ArrayRamdom(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];
//     for ( int i=0; i<rows; i++)
//     {
//         for (int j=0; j<columns; j++)
//         {
//           array[i,j]= new Random().Next(minValue,maxValue);
//         }
//     }
//     return array;
// }
// void Print2DArray(int[,] array)
// {
//     for (int i=0; i<array.GetLength(0);i++)
//     {
//         for ( int j=0; j<array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j]+ " ") ;
//         }
//         Console.WriteLine();
//     }
// }
//  void SortArrayMinMax(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
// }

// Console.WriteLine("input rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input columns");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input min");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input max");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray= ArrayRamdom(rows,columns,minValue,maxValue);

// Print2DArray(myArray);
// SortArrayMinMax(myArray);
// Console.WriteLine();
// Print2DArray(myArray);

//=================================================================
//Двумерный массив, нахождение строк с наименьшей суммой элементов.

// int[,] MassArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows,columns];
//     for (int i=0; i<rows; i++)
//     {
//         for (int j=0; j<columns; j++)
//         {
//             array[i,j]= new Random().Next(minValue,maxValue);
//         }
//     }
//     return array;
// }
// void PrintRardomArray(int[,] array)

//  {
//      for (int i=0; i<array.GetLength(0);i++)
//     {
//         for ( int j=0; j<array.GetLength(1); j++)
//         {
//              Console.Write(array[i,j]+ " ") ;
//          }
//         Console.WriteLine();
//      }
// }
// void SumMinCount(int[,] array)
// {
//     int sum=0;
//     int sumMin=0;
//     int k=0;
//     for (int i=0; i<array.GetLength(1); i++)
//     {
//         sumMin+=array[0,i];
//     }
//     for (int i = 0; i < array.GetLength(0); i++)
//     {   
//         for (int j = 0; j < array.GetLength(1); j++)
//         sum+= array[i,j];
//         if (sum<sumMin) 
//         {
//             sumMin= sum; k= i;
//         } 
//          Console.WriteLine(sum);
//          sum=0;
//     } 
//     Console.WriteLine($"{k+1} строка с наиненьшей суммой элементов " ); 
// }

// Console.WriteLine("input rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input columns");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input min");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input max");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int [,] myarray = MassArray(rows,columns,minValue,maxValue);
// PrintRardomArray(myarray);
// SumMinCount(myarray);

//=================================================================
// // Заполните спирально массив 4 на 4

// int n = 6;
// int[,] array= new int[n, n];

// int temp = 1;
// int i = 0;
// int j = 0;

// while (temp <= array.GetLength(0) * array.GetLength(1))
// {
//   array[i, j] = temp;
//   temp++;
//   if (i <= j + 1 && i + j < array.GetLength(1) - 1)
//     j++;
//   else if (i < j && i + j >= array.GetLength(0) - 1)
//     i++;
//   else if (i >= j && i + j > array.GetLength(1) - 1)
//     j--;
//   else
//     i--;
// }

// WriteArray(array);

// void WriteArray (int[,] array)
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
//=========================================================

//  Задайте две матрицы. Напишите программу произведения двух матриц.

// Console.WriteLine("Введите число строк 1 матрицы ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число столбцов 1 матрицы (и строк 2) ");
// int n= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число столбцов 2-й матрицы: ");
// int p= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("диапазон случайных чисел до ");
// int namber = Convert.ToInt32(Console.ReadLine());

// void CreateArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(namber);
//     }
//   }
// }

// void WriteArray (int[,] array)
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
// void resultant(int[,] array1, int[,] array2, int[,] resultarray1array2)
// {
//   for (int i = 0; i < resultarray1array2.GetLength(0); i++)
//   {
//     for (int j = 0; j < resultarray1array2.GetLength(1); j++)
//     {
//       int sum = 0;
//       for (int k = 0; k < array1.GetLength(1); k++)
//       {
//         sum += array1[i,k] * array2[k,j];
//       }
//       resultarray1array2[i,j] = sum;
//     }
//   }
// }

// int[,] array1 = new int[m, n];
// CreateArray(array1);
// Console.WriteLine($"Первая матрица:");
// WriteArray(array1);

// int[,] array2 = new int[n, p];
// CreateArray(array2);
// Console.WriteLine($"Вторая матрица:");
// WriteArray(array2);

// int[,] resultarray1array2 = new int[m,p];
// resultant(array1, array2, resultarray1array2);
// Console.WriteLine($"Произведение первой и второй матриц:");
// WriteArray(resultarray1array2);

//==================================================
// трехмерный массив из не повторяющихся чисел с добавлением индекса числа

void Input3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                array[i, j, k] = RandomValue(array, i, j, k); 
        }
    }
}

static int RandomValue(int[,,] array, int i, int j, int k)
{
    int value = default;
    bool flag = true;
    while (flag)
    {
        bool noStop = true;
         
        value = new Random().Next(0,100);
        for (int x = 0; x < array.GetLength(0) && noStop; x++)
        {
            for (int y = 0; y < array.GetLength(1) && noStop; y++)
            {
                for (int z = 0; z < array.GetLength(2) && noStop; z++)
                {
                    if (array[x, y, z] == value) 
                        noStop = false; 
                    if (x == i && y == j && z == k) 
                        flag = false; 
                }
            }
        }
    }
    return value;
}

void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++) 
                Console.Write($"{array[i, j, k], 1}({i},{j},{k})\t");
            Console.WriteLine();
        }
    }
}

Console.WriteLine("Введите значение Х ");
int x= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение y ");
int y= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение z ");
int z= Convert.ToInt32(Console.ReadLine());

 Console.WriteLine($"3D Массив размером {x} x {y} x {z}: ");

int[,,] array = new int[x, y, z];

Input3DArray(array);
Print3DArray(array);