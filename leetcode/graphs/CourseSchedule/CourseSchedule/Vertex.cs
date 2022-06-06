namespace CourseSchedule
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
        public Color State = Color.WHITE;

        public Vertex(int key) => Key = key;
    }
}