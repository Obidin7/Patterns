namespace SingletonBase
{
    public class Singleton
    {
        private static Singleton? _instance;
        private static int _count = 0;
        private Singleton()
        {
            Count = ++_count;
        }

        public static Singleton Instance => _instance ??= new Singleton();

        public int Count { get; set; }
    }
}
