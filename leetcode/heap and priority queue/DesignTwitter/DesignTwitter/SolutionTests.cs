namespace DesignTwitter
{
    public class SolutionTests
    {
        [Fact]
        public void Test()
        {
            Twitter twitter = new();
            twitter.PostTweet(1, 5);
            List<int> expected = new() { 5 };
            Assert.Equal(expected, twitter.GetNewsFeed(1));

            twitter.Follow(1, 2);
            twitter.PostTweet(2, 6);
            expected = new() { 6, 5 };
            Assert.Equal(expected, twitter.GetNewsFeed(1));
            
            twitter.Unfollow(1, 2);
            expected = new() { 5 };
            Assert.Equal(expected, twitter.GetNewsFeed(1));
        }
    }
}