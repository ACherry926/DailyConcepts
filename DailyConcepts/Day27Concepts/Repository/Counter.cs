namespace Day27Concepts.Repository
{
    public class Counter : ICounter
    {
        private int count;
        public void Increment() => count++;
        public int Get() => count;
    }
}
