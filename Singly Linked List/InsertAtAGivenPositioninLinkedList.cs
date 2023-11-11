internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        Node head = new Node(1);
        head.next = new Node(2);
        head.next.next = new Node(3);
        head.next.next.next = new Node(4);

        int pos = 1;
        int data = 9;

        Console.WriteLine($"\nBefore insert of value {data} at pos = {pos}");
        printLinkedList(head);


        head = InsertAtGivenPosition(head, pos, data);
        Console.WriteLine($"\nAfter insert of value {data} at pos = {pos}");

        printLinkedList(head);
        
    }

    private static Node InsertAtGivenPosition(Node head, int pos, int data)
    {
        Node temp = new Node(data);

        if(pos == 1)
        {
            temp.next = head;
            return temp;
        }

        Node curr = head;
        
        for(int i=1;i <= pos - 2 && curr != null; i++)
        {
            curr = curr.next;
        }
        
        if(curr != null)
        {
            return head;
        }

        temp.next = curr.next;
        curr.next = temp;

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


