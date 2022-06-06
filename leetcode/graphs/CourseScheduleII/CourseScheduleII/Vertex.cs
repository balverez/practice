namespace CourseScheduleII
{
    public class Vertex
    {
        public enum Color
        {
            WHITE,
            GRAY,
            BLACK
        }

        public int Key { get; set; }
        public Color State { get; set; } = Color.WHITE;
        public List<Vertex> Requirements { get; set; } = new();

        public Vertex(int key) => Key = key;
    }
}