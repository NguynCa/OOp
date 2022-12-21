using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPrimeNumber
{
    class OtherFunctions
    {
        public static int FindMax (int[] array)
        {
            int n = array.GetLength(0);
            int maxArray = array[0];
            for (int i = 1; i < n; i++)
            {
                if (maxArray < array[i])
                    maxArray = array[i];
            }
            return maxArray;
        }
    }
}
