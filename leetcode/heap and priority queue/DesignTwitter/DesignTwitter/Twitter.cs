namespace DesignTwitter
{
    //O(nk) space where n is the number of tweets and k is the number of users.
    public class Twitter
    {
        public int Time { get; set; } = 0;
        public int Capacity { get; } = 10;
        public Dictionary<int, LinkedList<(int, int)>> TweetMap { get; set; } = new();
        public Dictionary<int, HashSet<int>> FollowMap { get; set; } = new();

        //O(1) time
        public void PostTweet(int userId, int tweetId)
        {
            if (!TweetMap.ContainsKey(userId))
            {
                TweetMap[userId] = new();
                if (!FollowMap.ContainsKey(userId))
                    FollowMap[userId] = new() { userId };
            }

            LinkedList<(int, int)> tweets = TweetMap[userId];
            tweets.AddFirst((tweetId, Time++));

            if (TweetMap.Count > Capacity)
                tweets.RemoveLast();
        }

        //O(knlogn) time, where k represents the number of follows and n isthe number of tweets matched to each user.
        public IList<int> GetNewsFeed(int userId)
        {
            List<int> feed = new();
            if (FollowMap.ContainsKey(userId))
            {
                PriorityQueue<int, int> recent = new();
                foreach (int follow in FollowMap[userId])
                {
                    if (!TweetMap.ContainsKey(follow))
                        continue;

                    var tweets = TweetMap[follow];
                    foreach ((int tweet, int time) in tweets)
                    {
                        recent.Enqueue(tweet, time);
                        if (recent.Count > Capacity)
                            recent.Dequeue();
                    }
                }

                while (recent.Count > 0)
                    feed.Insert(0, recent.Dequeue());
            }

            return feed;
        }

        //O(1) time
        public void Follow(int followerId, int followeeId)
        {
            if (!FollowMap.ContainsKey(followerId))
                FollowMap[followerId] = new() { followerId };

            FollowMap[followerId].Add(followeeId);
        }

        //O(1) time
        public void Unfollow(int followerId, int followeeId)
        {
            if (FollowMap[followerId] != null && FollowMap[followerId].Contains(followeeId))
                FollowMap[followerId].Remove(followeeId);
        }
    }
}