namespace MyLinkedList
{
    public class Node<T>
    {
        public T Data {get; set;}
        public Node<T>? Next {get; set;}
        public Node<T>? Prev {get; set;}
        public Node(T Value)
        {
            Data = Value;
            Next = null;
            Prev = null;
        }
    }
    public class LinkedList<T>
    {
        private Node<T>? _head;
        private Node<T>? _tail;
        public LinkedList()
        {
            _head = null;
            _tail = null;
        }
        public void InsertHead(T Data)
        {   
            Node<T> newNode = new Node<T>(Data);
            if(_head == null)
            {
                _head = _tail = newNode;
                return;
            }
            else
            {
                newNode.Next = _head;
                _head.Prev = newNode;
                _head = newNode;
            }
        }
        public void InsertTail(T Data)
        {
            Node<T> newNode = new Node<T>(Data);
            if(_head == null)
            {
                _head = _tail = newNode;
                return;
            }
            Node<T>? Current = _head;
            while(Current.Next != null)
            {
                Current = Current.Next;
            }
            Current.Next = newNode;
        }
    }
}