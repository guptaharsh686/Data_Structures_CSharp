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
        head.next.next.next.next.next = head;


        //int data = 55;

        //Console.WriteLine($"\nBefore insert of value {data}");
        printLinkedList(head);


        head = InsertAtBeginingOfCircularLinkedList(head,4);
        Console.WriteLine($"\n");

        printLinkedList(head);
        
    }

    private static Node InsertAtBeginingOfCircularLinkedList(Node head,int x)
    {
        Node temp = new Node(x);
        if(head == null)
        {
            temp.next = temp;
            return temp;
        }

        Node curr = head;
        while(curr.next != head)
        {
            curr = curr.next;
        }

        temp.next = curr.next;
        curr.next = temp;

        return temp;

    }

    private static void printLinkedList(Node head)
    {
        if(head == null)
        {
            return;
        }
        Node curr = head;
        do
        {
            Console.Write($"{curr.data} ");
            curr = curr.next;
        } while (curr != head);
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



