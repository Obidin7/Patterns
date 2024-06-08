namespace SingletonSafe1
{
    public class Singleton
    {
        private static Singleton? _instance;
        private static int _count = 0;
        private static readonly object _lock = new();
        private Singleton()
        {
            Count = ++_count;
        }

        public static Singleton Instance
        {
            get
            {
                if (_instance is null)
                {
                    lock (_lock)
                    {
                        _instance ??= new Singleton();
                    }
                }

                return _instance;
            }
        }

        public int Count { get; set; }
    }
}
