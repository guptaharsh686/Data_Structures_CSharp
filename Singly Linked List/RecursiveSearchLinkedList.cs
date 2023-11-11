internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        Node head = new(1);
        head.next = new Node(2);
        head.next.next = new Node(3);
        head.next.next.next = new Node(4);


        Console.WriteLine(searchLL(head, 7, 1));

        int searchLL(Node head, int k, int pos)
        {
            if (head == null)
            {
                return -1;
            }

            if (head.data == k)
            {
                return pos;
            }

            return searchLL(head.next, k, pos + 1);
        }
    }
}

public class Node
{
    public int data;
    public Node? next;
    public Node(int data)
    {
        this.data = data;
        next = null;
    }
}


