namespace PredictiveTextGeneration
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new string[] { "d", "e", "f" }, "3")]
        [InlineData(new string[] { "g", "h", "i" }, "4")]
        [InlineData(new string[] { "dg", "dh", "di", "eg", "eh", "ei", "fg", "fh", "fi" }, "34")]
        public void Test1(string[] expected, string test)
        {
            HashSet<string> expectedSet = new(expected);

            Assert.Equal(expectedSet, new Solution().GenerateStrings(test));
        }

        [Fact]
        public void Test2()
        {
            HashSet<string> expected = new()
            {
                "agmt",
                "agmu",
                "agmv",
                "agnt",
                "agnu",
                "agnv",
                "agot",
                "agou",
                "agov",
                "ahmt",
                "ahmu",
                "ahmv",
                "ahnt",
                "ahnu",
                "ahnv",
                "ahot",
                "ahou",
                "ahov",
                "aimt",
                "aimu",
                "aimv",
                "aint",
                "ainu",
                "ainv",
                "aiot",
                "aiou",
                "aiov",
                "bgmt",
                "bgmu",
                "bgmv",
                "bgnt",
                "bgnu",
                "bgnv",
                "bgot",
                "bgou",
                "bgov",
                "bhmt",
                "bhmu",
                "bhmv",
                "bhnt",
                "bhnu",
                "bhnv",
                "bhot",
                "bhou",
                "bhov",
                "bimt",
                "bimu",
                "bimv",
                "bint",
                "binu",
                "binv",
                "biot",
                "biou",
                "biov",
                "cgmt",
                "cgmu",
                "cgmv",
                "cgnt",
                "cgnu",
                "cgnv",
                "cgot",
                "cgou",
                "cgov",
                "chmt",
                "chmu",
                "chmv",
                "chnt",
                "chnu",
                "chnv",
                "chot",
                "chou",
                "chov",
                "cimt",
                "cimu",
                "cimv",
                "cint",
                "cinu",
                "cinv",
                "ciot",
                "ciou",
                "ciov"
            };

            Assert.Equal(expected, new Solution().GenerateStrings("2468"));
        }
    }
}