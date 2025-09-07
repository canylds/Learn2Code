namespace DSAPlayground.LinkedLists;

public class MySinglyLinkedList<T>
{
    private Node _first;
    private Node _last;

    public MySinglyLinkedList()
    {

    }

    public MySinglyLinkedList(T firstData)
    {
        _first = new Node(firstData);
        _last = _first;
    }

    private class Node
    {
        public T _data { get; }
        public Node _next { get; set; }

        public Node(T data)
        {
            _data = data;
        }
    }

    public void PrintList()
    {
        Node currentNode = _first;

        while (currentNode != null)
        {
            Console.Write($"{currentNode._data} -> ");
            currentNode = currentNode._next;
        }

        Console.WriteLine("null");
    }

    public void AddFirst(T data)
    {
        if (_first == null)
        {
            _first = new Node(data);
            _last = _first;
        }
        else
        {
            Node newNode = new Node(data);
            newNode._next = _first;
            _first = newNode;
        }
    }

    public void AddLast(T data)
    {
        if (_first == null)
        {
            _first = new Node(data);
            _last = _first;
        }
        else
        {
            Node newNode = new Node(data);
            _last._next = newNode;
            _last = newNode;
        }
    }

    public void RemoveFirst()
    {
        if (_first != null)
            _first = _first._next;
    }

    public void RemoveLast()
    {
        if (_first == null)
            return;

        if (_first == _last)
        {
            _first = null;
            _last = null;
            return;
        }

        Node currentNode = _first;

        while (currentNode._next != _last)
            currentNode = currentNode._next;

        currentNode._next = null;
        _last = currentNode;
    }
}
