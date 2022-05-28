namespace ArrayRotation
{
    internal class Solution
    {
        //O(n) time
        //O(1) space
        public int[] RotateLeft(int[] arr, int k)
        {
            k = k % arr.Length;

            if (arr.Length <= 1 || k == 0)
                return arr;

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
