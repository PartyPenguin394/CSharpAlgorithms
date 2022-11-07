using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certification_Starting_Algor
{
    public static class LinearSearch
    { 
        public static int search(int[] arr, int x)
        {
            int N = arr.Length;
            for (int i = 0; i < N; i++)
            {
                if (arr[i] == x)
                    return i;
            }
            return -1;
        }
    }
}
