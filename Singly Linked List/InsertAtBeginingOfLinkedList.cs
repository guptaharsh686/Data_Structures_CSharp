internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        Node head = new(1);
        head.next = new Node(2);
        head.next.next = new Node(3);
        head.next.next.next = new Node(4);

        int value = 9;

        Console.WriteLine($"\nBefore insert of value {value}");
        printLinkedList(head);


        head = insertAtBegining(head, value);

        Console.WriteLine($"\nAfter insert of value {value}");

        printLinkedList(head);
        
    }

    private static Node insertAtBegining(Node head, int value)
    {
        Node tempNode = new Node(value);
        tempNode.next = head;
        return tempNode;
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


