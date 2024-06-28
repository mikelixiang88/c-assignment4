namespace ConsoleApp4;

public class MyList<T>
{
    private List<T> items = new List<T>();

    public void Add(T element)
    {
        items.Add(element);
    }

    public T Remove(int index)
    {
        T item = items[index];
        items.RemoveAt(index);
        return item;
    }

    public bool Contains(T element)
    {
        return items.Contains(element);
    }

    public void Clear()
    {
        items.Clear();
    }

    public void InsertAt(T element, int index)
    {
        items.Insert(index, element);
    }

    public void DeleteAt(int index)
    {
        items.RemoveAt(index);
    }

    public T Find(int index)
    {
        return items[index];
    }
}
