using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certification_Starting_Algor
{
    internal class QuickSortRecursive
    {

        public static void QuickSortRecursiveAlgorithm(ref int[] data, int left, int right)
        {
            int i = 0;
            if (left < right)
            {
                int q = Partition(ref data, left, right);
                i = q;
                QuickSortRecursiveAlgorithm(ref data, left, q - 1);
                QuickSortRecursiveAlgorithm(ref data, q + 1, right);
            }
            File.AppendAllText("QuickSortRecurvie-out.txt", i.ToString() + "\n");
        }

        private static int Partition(ref int[] data, int left, int right)
        {
            int pivot = data[right];
            int temp;
            int i = left;

            for (int j = left; j < right; ++j)
            {
                if (data[j] <= pivot)
                {
                    temp = data[j];
                    data[j] = data[i];
                    data[i] = temp;
                    i++;
                }
            }

            data[right] = data[i];
            data[i] = pivot;

            return i;
        }
    }
}
