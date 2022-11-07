using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certification_Starting_Algor
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                


                Stopwatch watch1 = new();
                int[] array1 = new int[] { 5, 2, 3 };
                Array.Sort(array1);
                watch1.Restart();
                var result1 = BinarySearch.BinarySearchIterative(array1, 5);
                //Write a line of text
                File.AppendAllText("QuickSortRecurvie-out.txt", $"Execution Time: {watch1.Elapsed} ms.\n");
                File.AppendAllText("QuickSortRecurvie-out.txt", $"The Index of array1 was: {result1}.\n");


                Stopwatch watch2 = new();
                int[] array2 = new int[] { 78, 55, 45, 98, 13 };
                watch2.Restart();
                BubbleSort.BubbleSortAlgorithm(array2);
                File.AppendAllText("QuickSortRecurvie-out.txt", $"\nExecution Time: {watch2.Elapsed} ms.\n");


                Stopwatch watch3 = new();
                int[] array3 = { 2, 3, 4, 10, 40 };
                int x = 10;
                watch3.Restart();

                // Function call
                int result = LinearSearch.search(array3, x);
                if (result == -1)
                {
                    File.AppendAllText("QuickSortRecurvie-out.txt", "Element is not present in array\n");
                }
                else
                {
                    File.AppendAllText("QuickSortRecurvie-out.txt", "Element is present at index "
                                        + result + "\n");
                    File.AppendAllText("QuickSortRecurvie-out.txt", $"Execution Time: {watch3.Elapsed} ms.\n");
                }


                Stopwatch watch4 = new();
                int[] array4 = new int[10] { 56, 1, 99, 67, 89, 23, 44, 12, 78, 34 };
                watch3.Restart();
                SelectionSort.SelectionSortAlgorithm(array4);
                File.AppendAllText("QuickSortRecurvie-out.txt", $"\nExecution Time: {watch4.Elapsed} ms.\n");


                Stopwatch watch5 = new();
                int[] array5 = new int[] { -1, 25, -58964, 8547, -119, 0, 78596 };
                watch3.Restart();
                QuickSortRecursive.QuickSortRecursiveAlgorithm(ref array5, 0, array5.Length - 1);

                File.AppendAllText("QuickSortRecurvie-out.txt", $"\nExecution Time: {watch5.Elapsed} ms.\n");

                Stopwatch watch6 = new();
                int[] arr = { 12, 11, 13, 5, 6, 7 };
                File.AppendAllText("QuickSortRecurvie-out.txt", "Given Array\n");
                watch1.Restart();
                //Write a line of text
                File.AppendAllText("QuickSortRecurvie-out.txt", $"Execution Time: {watch6.Elapsed} ms.\n");

                Algorithm.printArray(arr);

                Algorithm ob = new Algorithm();
                ob.sort(arr, 0, arr.Length - 1);
                File.AppendAllText("QuickSortRecurvie-out.txt", "\nSorted array\n");
                Algorithm.printArray(arr);

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message + "\n");
            }
            finally
            {
                Console.WriteLine("Executing finally block.\n");
            }
            
        }
    }
}
