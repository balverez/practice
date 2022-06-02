namespace MinStack
{
    public class SolutionTests
    {
        [Fact]
        public void Test()
        {
            MinStack stack = new();
            stack.Push(-2);
            stack.Push(0);
            stack.Push(-3);
            Assert.Equal(-3, stack.GetMin());
            
            stack.Pop();
            Assert.Equal(0, stack.Top());

            Assert.Equal(-2, stack.GetMin());
        }

        [Fact]
        public void Test2()
        {
            MinStack stack = new();
            stack.Push(-2);
            Assert.Equal(-2, stack.GetMin());

            stack.Pop();
        }
    }
}