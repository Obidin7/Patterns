using SingletonBase;

//Console.WriteLine("Singletone:");
//var singletone1 = Singletone.Instance;
//var singletone2 = Singletone.Instance;
//Console.WriteLine($"Number of creations: {Singletone.Count}");


//Problem: The Singletone class is not thread - safe.

Parallel.For(0, 20, _ =>
    {
        var singletone = Singleton.Instance;
        Console.WriteLine($"Number of creations: {singletone.Count}");
    });
