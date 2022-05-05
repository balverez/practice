using System;
using System.Linq;

namespace FlipImage
{
    public class Solution
    {
        public int[][] FlipImage(int[][] image)
        {
            return image.Reverse().ToArray();
        }
    }
}
