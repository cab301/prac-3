/// <summary>
/// A circular linked list class
/// </summary>
/// <typeparam name="T">The type of the data in the linked list</typeparam>
class CircularLinkedList<T>
{
    /// <summary>
    /// The first node in the linked list
    /// </summary>
    public Node<T> Head { get; set; }
    /// <summary>
    /// The last node in the linked list
    /// </summary>
    public Node<T> Tail { get; set; }
    /// <summary>
    /// The number of nodes in the linked list
    /// </summary>
    public int Count { get; set; }
    /// <summary>
    /// Creates a new circular linked list, with no nodes
    /// </summary>
    public CircularLinkedList()
    {
        Head = null;
        Tail = null;
        Count = 0;
    }
    /// <summary>
    /// Adds a new node to the end of the linked list
    /// </summary>
    /// <param name="data">The data to add to the linked list</param>
    public void Add(T data)
    {
        Node<T> newNode = new Node<T>(data);
        // If the linked list is empty, make the new node the head
        if(Head == null)
        {
            Head = newNode;
        }
        // Otherwise, add the new node to the end of the linked list
        else
        {
            Tail.Next = newNode;
        }
        // Make the new node the tail and point it back to the head
        Tail = newNode;
        Tail.Next = Head;
        Count++;
    }

    public T RemoveNode(Node<T> node){
        if(node == null)
        {
            throw new InvalidOperationException("The node is null");
        }
        if(Head == null)
        {
            throw new InvalidOperationException("The linked list is empty");
        }
        // If the node is the head, remove the head
        if(node == Head)
        {
            return RemoveHead();
        }
        // If the node is the tail, remove the tail
        if(node == Tail)
        {
            return RemoveTail();
        }
        // Otherwise, remove the node from the middle of the linked list
        Node<T> current = Head;
        while(current.Next != node)
        {
            current = current.Next;
        }
        current.Next = node.Next;
        Count--;
        return node.Value;
    }

    private T RemoveHead()
    {
        if(Head == null)
        {
            throw new InvalidOperationException("The linked list is empty");
        }
        T result = Head.Value;
        // If there is only one node in the linked list, remove it
        if(Head == Tail)
        {
            Head = null;
            Tail = null;
        }
        // Otherwise, remove the head
        else
        {
            Head = Head.Next;
            Tail.Next = Head;
        }
        Count--;
        return result;
    }

    private T RemoveTail()
    {
        if(Tail == null)
        {
            throw new InvalidOperationException("The linked list is empty");
        }
        T result = Tail.Value;
        // If there is only one node in the linked list, remove it
        if(Head == Tail)
        {
            Head = null;
            Tail = null;
        }
        // Otherwise, remove the tail
        else
        {
            Node<T> current = Head;
            while(current.Next != Tail)
            {
                current = current.Next;
            }
            Tail = current;
            Tail.Next = Head;
        }
        Count--;
        return result;
    }

    /// <summary>
    /// Returns a string representation of the linked list
    /// </summary>
    /// <returns>A string representation of the linked list</returns>
    public override string ToString()
    {
        if(Head == null)
        {
            return "Empty";
        }
        string result = "";
        Node<T> current = Head;
        do
        {
            result += current.Value + ", ";
            current = current.Next;
        } while(current != Head);
        return result;
    }
}