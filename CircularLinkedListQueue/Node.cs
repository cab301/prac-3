/// <summary>
/// A node class for a circular linked list
/// </summary>
/// <typeparam name="T">The type of the data in the linked list</typeparam>
class Node<T>{
    /// <summary>
    /// The value stored in the node
    /// </summary>
    public T Value { get; set; }
    /// <summary>
    /// The next node in the linked list
    /// </summary>
    public Node<T> Next { get; set; }
    /// <summary>
    /// Creates a new node with the given data
    /// </summary>
    public Node(T data){
        Value = data;
        Next = null;
    }
}