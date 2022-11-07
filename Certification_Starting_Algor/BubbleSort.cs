using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certification_Starting_Algor
{
    public static class BubbleSort
    {
        public static void BubbleSortAlgorithm(int[] arr)
        {
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            File.AppendAllText("QuickSortRecurvie-out.txt", "Sorted: \n");
            foreach (int p in arr)
            {
                File.AppendAllText("QuickSortRecurvie-out.txt", p + "\n");
            }  
        }
    }
}

