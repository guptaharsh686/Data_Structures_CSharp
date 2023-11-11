internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        Node head = new Node(10);
        head.next = new Node(20);
        head.next.next = new Node(30);
        head.next.next.next = new Node(40);

        int data = 55;

        Console.WriteLine($"\nBefore insert of value {data}");
        printLinkedList(head);


        head = SortedinsertLinkedList(head, data);
        Console.WriteLine($"\nAfter insert of value {data}");

        printLinkedList(head);
        
    }

    private static Node SortedinsertLinkedList(Node head,int data)
    {
        Node temp = new Node(data);

        if(head == null)
        {
            return temp;
        }

        if(head.data > data)
        {
            temp.next = head;
            return temp;
        }

        Node curr = head;

        while (curr.next != null )
        {
            if (curr.next.data > data)
                break;

            curr = curr.next;
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


