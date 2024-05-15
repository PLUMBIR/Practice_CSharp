using System;

class MyList<T>
{
    private T[] items;
    private int count;

    public MyList()
    {
        items = new T[4];
        count = 0;
    }

    public void Add(T item)
    {
        if (count == items.Length)
        {
            Array.Resize(ref items, items.Length * 2);
        }
        items[count] = item;
        count++;
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }
            return items[index];
        }
    }

    public int Count
    {
        get { return count; }
    }
}

static class MyListExtensions
{
    public static T[] GetArray<T>(this MyList<T> list)
    {
        T[] newArray = new T[list.Count];
        for (int i = 0; i < list.Count; i++)
        {
            newArray[i] = list[i];
        }
        return newArray;
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyList<int> myList = new MyList<int>();

        myList.Add(10);
        myList.Add(20);
        myList.Add(30);

        int[] array = myList.GetArray();

        Console.WriteLine("Элементы массива:");
        foreach (int item in array)
        {
            Console.WriteLine(item);
        }
    }
}
