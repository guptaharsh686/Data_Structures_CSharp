internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        Node head = new Node(1);
        //head.next = new Node(2);
        //head.next.next = new Node(3);
        //head.next.next.next = new Node(4);

        //int value = 9;

        //Console.WriteLine($"\nBefore insert of value {value}");
        printLinkedList(head);


        head = DeleteLastNode(head);
        Console.WriteLine("\nAfter delete");
        //Console.WriteLine($"\nAfter insert of value {value}");

        printLinkedList(head);
        
    }

    private static Node DeleteLastNode(Node head)
    {
        if(head == null || head.next == null)
        {
            return null;
        }

        //no need to worry about memory deallocation
        Node curr = head;

        while(curr.next.next != null)
        {
            curr = curr.next;
        }

        curr.next = null;

        return head;
        
    }

    private static void printLinkedList(Node head)
    {
        Node curr = head;
        while (curr != null)
        {
            Console.Write(curr.data + " ");
            curr = curr.next;
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


