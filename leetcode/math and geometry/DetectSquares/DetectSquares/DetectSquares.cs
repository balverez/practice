namespace DetectSquares
{
    //(n) space
    public class DetectSquares
    {
        public Dictionary<(int, int), int> Points { get; set; } = new();

        //O(1) time
        public void Add(int[] point)
        {
            int x = point[0];
            int y = point[1];
            Points[(x, y)] = Points.GetValueOrDefault((x, y), 0) + 1;
        }

        //O(n) time
        public int Count(int[] point)
        {
            int qx = point[0];
            int qy = point[1];
            int count = 0;
            foreach ((int x, int y) in Points.Keys)
            {
                if (Math.Abs(qx - x) != Math.Abs(qy - y) || qx == x || !Points.ContainsKey((x, qy)) || !Points.ContainsKey((qx, y)))
                    continue;

                int current = Points[(x, y)];
                current *= Points[(x, qy)];
                current *= Points[(qx, y)];
                count += current;
            }

            return count;
        }
    }
}