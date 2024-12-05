using System;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Day4
{
    internal class Program
    {
        enum DayOfWeek
        {   
            Sunday = 1,
            Saturday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday
  
        }
        static void Main(string[] args)
        {
            #region ARR &  IndexOutOfRangeException
            //int[] Arr1 = new int[3];
            //int[] Arr2 = new int[] { 3, 4 };
            //int[] Arr3 = { 5, 6, 7, 8 };

            //Console.WriteLine(Arr1[1]); // Q : default value in array of int is zero
            //for (int i = 0; i < Arr1.Length; i++)
            //{
            //    Console.WriteLine($"({i + 1}) Enter number : ");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    Arr1[i] = num;
            //}

            //for (int i = 0; i < Arr1.Length; i++)
            //    Console.WriteLine($"{Arr1[i]} ");

            //try
            //{
            //    Console.WriteLine("print value in index: ");
            //    int idx = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(Arr2[idx]);
            //}
            //catch (IndexOutOfRangeException)
            //{
            //    Console.WriteLine("out of range :( ");
            //}
            #endregion

            #region shallow & deep copy
            //int[] Arr1 = { 1, 2, 3 };
            //int[] Arr2 = { 4, 5, 6 };

            //Arr2 = Arr1; //shallow copy : copy address of arr1 ,{ 4, 5, 6 } became unreachable 
            //Console.WriteLine(Arr1[0]);
            //Console.WriteLine(Arr2[0]);

            //int[] Arr3 = (int[])Arr2.Clone();//deep copy : create new object at heap with the same data of arr2 with new address
            //Arr2[0] = 140;
            //Console.WriteLine(Arr1[0]); // 140 shallow copy
            //Console.WriteLine(Arr2[0]); // 140 shallow copy
            //Console.WriteLine(Arr3[0]); // 1 deep copy

            //int[] ArrCopy = new int[Arr3.Length];
            ////Array.Copy(sourceArray, destinationArray, length);
            //Array.Copy(Arr3, ArrCopy, Arr3.Length);
            //Console.WriteLine(ArrCopy[0]); // 1
            //Arr3[1] = 60;
            //Console.WriteLine(Arr3[1]); // 60 
            //Console.WriteLine(ArrCopy[1]); // 2 deep coopy

            ///*
            // Array.Copy => create deep copies to range of elements from one array to another array
            // Array.clone => create a new array object containing all the elements in the original array  
            // */ 
            #endregion

            #region 2D Array
            //int[,] Grades = new int[3,3] ;

            //for (int i = 0; i < Grades.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Marks for student number {i+1}");
            //    for (int j = 0; j < Grades.GetLength(1); )
            //    {
            //        Console.Write($"Please enter the mars of subject {j+1} : ");
            //        bool F = int.TryParse(Console.ReadLine(), out Grades[i,j]);
            //        j = (F && Grades[i, j] >= 0) ? ++j : j ;
            //    }               
            //}
            //for (int i = 0; i < Grades.GetLength(0); i++)
            //{
            //    Console.Write($"St{i+1} : ");
            //    for (int j = 0; j < Grades.GetLength(1); j++)
            //    {
            //        Console.Write($"{Grades[i, j]} ");
            //    }

            //    Console.WriteLine();
            //}

            //Console.WriteLine(Grades.Length); // return n * m => number of all element in array
            //Console.WriteLine(Grades.GetLength(0)); // return n or m => number of ele in rows(n) 
            #endregion

            #region Array Functions
            //int[] Arr = { 10, 50, 100, 80, 60 };
            //Console.Write($"original array : ");
            //foreach (int i in Arr)
            //{
            //    Console.Write($"{i} ");
            //}
            ////(Sort, Reverse, IndexOf, Copy, Clear)
            //Array.Sort(Arr);
            //Console.Write($"\nsorted array : ");
            //foreach (int i in Arr) 
            //{ 
            //    Console.Write($"{i} ");
            //}

            //Array.Reverse(Arr);
            //Console.Write($"\nReverse array : ");
            //foreach (int i in Arr)
            //{
            //    Console.Write($"{i} ");
            //}

            //Console.Write("\nEnter value in array to show its index : ");
            //int Val = int.Parse( Console.ReadLine() );
            //int Idx = Array.IndexOf(Arr, Val);
            //Console.WriteLine($"index of value {Val} is {Idx}");

            //int[] ArrCopy = new int[Arr.Length];
            //Array.Copy(Arr, ArrCopy, Arr.Length);
            //Console.Write($"copied array : ");
            //foreach (int i in Arr)
            //{
            //    Console.Write($"{i} ");
            //}

            //Array.Clear(ArrCopy);
            ///*
            // Array.ConstrainedCopy() => This method is used to copy a range of 
            // elements from an Array starting at the specified source index and 
            // pastes them to another Array starting at the specified destination index

            // */ 
            #endregion

            #region Loops
            //int[] Arr = { 1, 2, 3, 4, 5 };

            //Console.WriteLine("For ");
            //for (int i = 0; i < Arr.Length; i++)
            //    Console.Write($"{Arr[i]} ");

            //Console.WriteLine("\n---------------------------------");

            //Console.WriteLine("Foreach ");
            //foreach (int i in Arr)
            //    Console.Write($"{i} ");

            //Console.WriteLine("\n---------------------------------");

            //Console.WriteLine("while ");
            //int j = Arr.Length - 1;
            //while (j >= 0)
            //{
            //    Console.Write($"{Arr[j]} ");
            //    j--;
            //}

            ///*
            // Why is foreach preferred for read-only operations on arrays?
            //    more readable , take a copy of array so we can not modify ,
            //    automatically handles the iteration boundaries , 
            // */ 
            #endregion

            #region validation 
            //int Num;
            //do
            //{
            //    Console.WriteLine("Enter odd number : ");

            //} while (!int.TryParse(Console.ReadLine(), out Num) || Num % 2 == 0);
            /*
             *  Why is input validation important when working with user inputs?
                Prevent Errors and Crashes , Ensure Data Integrity
                Enhance User Experience , Improve Security             
             */
            #endregion

            #region print 2D Array as a matrix
            //int[,] TwoDArr = new int[,] { { 1, 2, 3 }, { 4, 5, 6 },{ 7, 8, 9 } };

            //for (int i = 0; i < TwoDArr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < TwoDArr.GetLength(1); j++)
            //    {
            //        Console.Write($"{TwoDArr[i, j]} ");
            //    }

            //    Console.WriteLine();
            //} 
            #endregion


            #region if & switch 
            //int MonthNumber;

            //do
            //{
            //    Console.Write("Enter the month number from 1 to 5 : ");

            //} while (!int.TryParse(Console.ReadLine(), out MonthNumber));



            //if (MonthNumber == 1)
            //    Console.WriteLine("January");
            //else if (MonthNumber == 2)
            //    Console.WriteLine("February"); 
            //else if (MonthNumber == 3)
            //    Console.WriteLine("March"); 
            //else if (MonthNumber == 4)
            //    Console.WriteLine("April"); 
            //else if (MonthNumber == 5)
            //    Console.WriteLine("May"); 
            //else
            //    Console.WriteLine("Invalid month number");



            //switch (MonthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("January");
            //        break;
            //    case 2:
            //        Console.WriteLine("February");
            //        break;
            //    case 3:
            //        Console.WriteLine("March");
            //        break;
            //    case 4:
            //        Console.WriteLine("April");
            //        break;
            //    case 5:
            //        Console.WriteLine("May");
            //        break;

            //    default:
            //        Console.WriteLine("Invalid month number");                   
            //        break;
            //}

            ///*
            // * When should you prefer a switch statement over if-else?
            //     on variable of type numeric check equality 

            // */ 
            #endregion

            #region IndexOf() VS LastIndexOf()
            //int[] Arr = { 20, 60, 10, 5, 1, 80, 80 };

            //Console.Write($"original array : ");
            //foreach (int i in Arr)
            //{
            //    Console.Write($"{i} ");
            //}

            //Array.Sort(Arr);
            //Console.Write($"\nsorted array : ");
            //foreach (int i in Arr)
            //{
            //    Console.Write($"{i} ");
            //}

            //int Val;
            //do
            //{
            //    Console.Write("\nEnter exist value in array to show its index : ");

            //} while (!int.TryParse(Console.ReadLine(), out Val) || Array.IndexOf(Arr, Val) == -1);

            //int Idx = Array.IndexOf(Arr, Val);
            //Console.WriteLine($"index of value {Val} is {Idx}");
            //Idx = Array.LastIndexOf(Arr, Val);
            //Console.WriteLine($"LastIndexOf of value {Val} is {Idx}");

            ///*
            // * Time Complexity of Array.Sort() is  O(nlogn)
            //*/ 
            #endregion

            #region Sum by for VS foreach
            //int[] Arr = { 1, 2, 3, 4, 5};
            //int Sum = 0 ;
            //for (int i = 0; i < Arr.Length; i++)
            //{
            //    Sum += Arr[i];
            //}
            //Console.WriteLine($"sum = {Sum} ");
            //Sum = 0;
            //foreach (int i in Arr)
            //{
            //    Sum += i ;
            //}
            //Console.WriteLine($"sum = {Sum} ");

            ///*
            // * Which loop is more efficient for calculating the sum of an 
            //   array, and why? 
            //   => for is More Efficient because it avoids the enumerator 
            //      overhead of foreach
            //*/ 
            #endregion

            //************ Part 02 **********************

            int Day;
            do
            {
                Console.Write("Enter a number from 1 to 7 to get the day: ");
            }while (!int.TryParse(Console.ReadLine(), out Day) || Day < 1 || Day > 7);

            DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Day.ToString());
            Console.WriteLine($"The day is: {day}");
            
         

        }
    }
}
