using System.Collections;

namespace Flyweight;

class FlyweightFactory
{
    private readonly Hashtable _pool = [];

    public FlyweightBase GetConcreteFlyweight(string key)
    {
        if (!_pool.ContainsKey(key))
        {
            _pool.Add(key, new ConcreteFlyweight());
        }            

        return _pool[key] as FlyweightBase;
    }

    public FlyweightBase GetUnsharedConcreteFlyweight()
    {
        return new UnsharedConcreteFlyweight();
    }
}
