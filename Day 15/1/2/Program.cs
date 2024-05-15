using System;

class MyDictionary<TKey, TValue>
{
    private TKey[] keys;
    private TValue[] values;
    private int count;

    public MyDictionary()
    {
        keys = new TKey[4];
        values = new TValue[4];
        count = 0;
    }

    public void Add(TKey key, TValue value)
    {
        if (count == keys.Length)
        {
            Array.Resize(ref keys, keys.Length * 2);
            Array.Resize(ref values, values.Length * 2);
        }
        keys[count] = key;
        values[count] = value;
        count++;
    }

    public TValue this[TKey key]
    {
        get
        {
            for (int i = 0; i < count; i++)
            {
                if (keys[i].Equals(key))
                {
                    return values[i];
                }
            }
            throw new KeyNotFoundException($"The key '{key}' was not found.");
        }
    }

    public int Count
    {
        get { return count; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();

        myDictionary.Add("one", 1);
        myDictionary.Add("two", 2);
        myDictionary.Add("three", 3);

        Console.WriteLine($"Значение для ключа 'one': {myDictionary["one"]}");
        Console.WriteLine($"Значение для ключа 'two': {myDictionary["two"]}");
        Console.WriteLine($"Значение для ключа 'three': {myDictionary["three"]}");
    }
}
