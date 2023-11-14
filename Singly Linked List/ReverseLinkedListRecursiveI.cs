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


        head = ReverseALinkedListRecursive(head);
        Console.WriteLine($"\n");

        printLinkedList(head);
        
    }

    private static Node ReverseALinkedListRecursive(Node head)
    {
        if (head == null)
        {
            return null;
        }
        
        if(head.next != null) 
        {
            Node rest_head = ReverseALinkedListRecursive(head.next);

            //Node rest_tail = rest_head;

            //while (rest_tail.next != null) 
            //{
            //    rest_tail = rest_tail.next;
            //}

            Node rest_tail = head.next;

            rest_tail.next = head;
            head.next = null;

            return rest_head;
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



