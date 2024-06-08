namespace SingletonWithInterface
{
    public class Singleton
    {
        private static readonly Lazy<Singleton> _instance = new(() => new Singleton());
        private static int _count = 0;
        private Singleton()
        {
            Count = ++_count;
        }

        public static Singleton Instance => _instance.Value;

        public int Count { get; set; }
    }
}
