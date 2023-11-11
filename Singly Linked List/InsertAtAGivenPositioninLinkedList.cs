internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        Node head = new Node(1);
        head.next = new Node(2);
        head.next.next = new Node(3);
        head.next.next.next = new Node(4);

        int pos = 3;
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

        if(head == null && pos == 1)
        {
            return temp;
        }

        Node curr = head;

        int x = 1;

        while(curr.next != null && x < pos - 1)
        {
            curr = curr.next;
            x++;
        }

        if(x != pos - 1)
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


