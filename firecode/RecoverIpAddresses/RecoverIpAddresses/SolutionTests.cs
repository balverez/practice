namespace RecoverIpAddresses
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new string[] { "1.0.1.0" }, "1010")]
        [InlineData(new string[] { "192.168.20.40", "192.168.204.0" }, "1921682040")]
        [InlineData(new string[] { "255.255.255.255" }, "255255255255")]
        [InlineData(new string[] { "255.10.255.10", "255.102.55.10" }, "2551025510")]
        [InlineData(new string[] { "1.232.134.32", "12.32.134.32", "123.2.134.32", "123.21.34.32", "123.213.4.32", "123.213.43.2" }, "123213432")]
        public void Test(string[] expected, string test)
        {
            HashSet<string> expectedSet = new(expected);
            Assert.Equal(expected, new Solution().GenerateIpAddresses(test));
        }
    }
}