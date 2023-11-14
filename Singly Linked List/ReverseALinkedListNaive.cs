internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        Node head = new Node(10);
        head.next = new Node(20);
        head.next.next = new Node(30);
        head.next.next.next = new Node(40);
        head.next.next.next.next = new Node(50);

        //int data = 55;

        //Console.WriteLine($"\nBefore insert of value {data}");
        printLinkedList(head);


        head = ReverseALinkedListNaive(head);
        Console.WriteLine($"\n");

        printLinkedList(head);
        
    }

    private static Node ReverseALinkedListNaive(Node head)
    {
        if(head == null)
        {
            return null;
        }

        Node curr = head;

        int count = 0;

        while (curr != null)
        {
            curr = curr.next;
            count++;
        }

        var arr = new int[count];
        int i = 0;
        curr = head;
        while (curr != null)
        {
            arr[i] = curr.data;
            curr = curr.next;
            i++;
        }
        curr = head;
        for(int x=count-1; x >= 0; x--)
        {
            curr.data = arr[x];
            curr = curr.next;
        }

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



