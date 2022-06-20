namespace TaskScheduler
{
    public class Solution
    {
        //O(nlogn * k) time, where k represents the amount of possible tasks in the waiting queue.
        //O(n) space
        public int LeastInterval(char[] tasks, int n)
        {
            Dictionary<char, int> inst = new();

            foreach (char task in tasks)
                inst[task] = inst.GetValueOrDefault(task, 0) + 1;

            PriorityQueue<char, int> pq = new(Comparer<int>.Create((int x, int y) => y.CompareTo(x)));
            foreach (char task in inst.Keys)
                pq.Enqueue(task, inst[task]);

            Queue<(char, int)> wq = new();
            int time = 0;
            int instructions = tasks.Length;
            while (instructions > 0)
            {
                while (wq.Count > 0 && wq.Peek().Item2 == time)
                {
                    (char task, int cooldown) = wq.Dequeue();
                    pq.Enqueue(task, inst[task]);
                }

                if (pq.Count > 0)
                {
                    char task = pq.Dequeue();
                    inst[task]--;
                    instructions--;
                    if (inst[task] > 0)
                        wq.Enqueue((task, time + n + 1));
                }

                time++;
            }

            return time;
        }
    }
}