public class Queue<T>
{
    /// <summary>
    /// Node class for the queue
    /// </summary>
    public class Node
    {
        /// <summary>
        /// Value of the node
        /// </summary>
        public T Value { get; set; }

        /// <summary>
        /// Reference to the next node in the queue
        /// </summary>
        public Node Next { get; set; }

        /// <summary>
        /// Constructor for a new node
        /// </summary>
        /// <param name="value">Value of the node</param>
        public Node(T value)
        {
            Value = value;
        }
    }

    /// <summary>
    /// Head of the queue
    /// </summary>
    private Node head;

    /// <summary>
    /// Tail of the queue
    /// </summary>
    private Node tail;

    /// <summary>
    /// Number of elements in the queue
    /// </summary>
    private int count;

    /// <summary>
    /// Method to check the type of the queue
    /// </summary>
    /// <returns>The type of the queue</returns>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary>
    /// Adds an element to the end of the queue
    /// </summary>
    /// <param name="item">Element to add</param>
    public void Enqueue(T item)
    {
        Node newNode = new Node(item);

        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.Next = newNode;
            tail = newNode;
        }

        count++;
    }

    /// <summary>
    /// Returns the number of elements in the queue
    /// </summary>
    /// <returns>Number of elements</returns>
    public int Count()
    {
        return count;
    }
}