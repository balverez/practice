using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRotation
{
    internal class Solution
    {
        public int[] RotateLeft(int[] arr, int k)
        {
            if (arr.Length <= 1)
                return arr;

            k = k % arr.Length;

            arr = Reverse(arr, 0, arr.Length - 1);
            arr = Reverse(arr, 0, arr.Length - 1 - k);
            return Reverse(arr, arr.Length - k, arr.Length - 1);
        }

        private int[] Reverse(int[] arr, int left, int right)
        {
            while (left < right)
            {
                int temp = arr[left];
                arr[left++] = arr[right];
                arr[right--] = temp;
            }

            return arr;
        }
    }
}
