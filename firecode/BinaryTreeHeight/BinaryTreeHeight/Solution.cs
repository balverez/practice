﻿using System;

namespace BinaryTreeHeight
{
    internal class Solution
    {
        //O(n) time
        //O(n) space
        internal int GetHeight(TreeNode? root) => root == null
            ? 0
            : 1 + Math.Max(GetHeight(root.Left), GetHeight(root.Right));
    }
}