namespace ReverseBits
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(0b00111001011110000010100101000000, 0b00000010100101000001111010011100)]
        [InlineData(0b10111111111111111111111111111111, 0b11111111111111111111111111111101)]
        public void Test(uint expected, uint n) => Assert.Equal(expected, new Solution().reverseBits(n));
    }
}