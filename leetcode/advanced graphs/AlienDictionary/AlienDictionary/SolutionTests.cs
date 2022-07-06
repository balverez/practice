namespace AlienDictionary
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            string expected = "wertf";
            string[] words =
            {
                "wrt",
                "wrf",
                "er",
                "ett",
                "rftt"
            };

            Assert.Equal(expected, new Solution().AlienOrder(words));
        }

        [Fact]
        public void Test2()
        {
            string expected = "zx";
            string[] words =
            {
                "z",
                "x"
            };

            Assert.Equal(expected, new Solution().AlienOrder(words));
        }

        [Fact]
        public void Test3()
        {
            string expected = "";
            string[] words =
            {
                "z",
                "x",
                "z"
            };

            Assert.Equal(expected, new Solution().AlienOrder(words));
        }

        [Fact]
        public void Test4()
        {
            string expected = "z";
            string[] words =
            {
                "z",
                "z"
            };

            Assert.Equal(expected, new Solution().AlienOrder(words));
        }

        [Fact]
        public void Test5()
        {
            string expected = "cbaz";
            string[] words =
            {
                "ac",
                "ab",
                "zc",
                "zb"
            };

            Assert.Equal(expected, new Solution().AlienOrder(words));
        }
    }
}