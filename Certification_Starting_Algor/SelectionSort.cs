using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certification_Starting_Algor
{
    public static class SelectionSort
    {
        public static void SelectionSortAlgorithm(int[] arr)
        {
            int n = 10;
            File.AppendAllText("QuickSortRecurvie-out.txt", "\nSelection sort Initial array is:");
            for (int i = 0; i < n; i++)
            {
                File.AppendAllText("QuickSortRecurvie-out.txt", arr[i] + "\n");
            }
            int temp, smallest;
            for (int i = 0; i < n - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[smallest])
                    {
                        smallest = j;
                    }
                }
                temp = arr[smallest];
                arr[smallest] = arr[i];
                arr[i] = temp;
            }
            File.AppendAllText("QuickSortRecurvie-out.txt", "\n\nSorted array is: ");
            for (int i = 0; i < n; i++)
            {
                File.AppendAllText("QuickSortRecurvie-out.txt", arr[i] + "\n");
            }
        } 
    }
}
