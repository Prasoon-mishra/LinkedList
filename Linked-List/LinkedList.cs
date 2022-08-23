namespace Linked_List
{
    public class Node //    CREATING THE NODE
    {
        public int element;
        public Node next;

        public Node(int a, Node n) // INITIALIZING THE VARIABLES USING COSTRUCTOR
        {
            this.element = a;
            this.next = n;
        }
    }
    internal class LinkedList
    {
        public Node head;
        public Node tail;
        public int size;

        public LinkedList()
        {
            head = null;
            tail = null;
            size= 0;    
        }

        public int Length()  //CALCULATING THE LENGTH OF LINKED LIST
        {
            return size;
        }

        public bool isEmpty() // TO CHECK WHETHER THE LIST IS EMPTY OR NOT
        {
            return size == 0;
        }

        public void addLast(int e) // ADDING THE NODES FROM THE LAST 
        {
            Node newest = new Node(e,null);
            if(isEmpty())
            {
                head = newest;
            }
            else
            {
                tail.next = newest;
            }
            tail = newest;
            size++;
        }

        public void addFirst(int e)
        {
            Node newest = new Node(e, null);
            if(isEmpty())
            {
                head=newest;
                tail=newest;
            }
            else
            {
                newest.next = head;
                head = newest;
            }
            size++;
        }

        public void AddAnyWhere(int e , int position)
        {
            if(position <=0 || position >= size)
            {
                Console.WriteLine("Invalid Position");
                return;
            }
            else
            {
                Node newest = new Node(e, null);
                Node runner = head;
                int i = 1;
                while (i < position - 1)
                {
                    runner = runner.next;
                    i++;
                }
                newest.next = runner.next;
                runner.next = newest;
                size++;
            }
        }

        public void RemoveFirst()
        {
            if (isEmpty())
            {
                Console.WriteLine("There is no node to delete");
                return ;
            }
            int e = head.element;
            head = head.next;
            size--;
            if (isEmpty())
            {
                tail = null;
                return ;
            }
        }
        public void display() 
        {
            Node runner = head;
            while(runner.next != null)
            {
                Console.Write(runner.element + " --> ");
                runner = runner.next;
            }
            Console.WriteLine(runner.element);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------Linked List-------------------");
            LinkedList linkedList = new LinkedList();
            linkedList.addLast(7);
            linkedList.addLast(8);
            linkedList.addLast(9);
            linkedList.addLast(10);
            linkedList.addLast(11);
            linkedList.addLast(12);
            linkedList.addLast(13);
            linkedList.addLast(14);
            linkedList.addLast(14);
            //linkedList.addFirst(3456);
            //linkedList.AddAnyWhere(45, 5);
            linkedList.RemoveFirst();
            Console.WriteLine("The length of liked list : "+linkedList.Length());
            linkedList.display();
        }
    }
}