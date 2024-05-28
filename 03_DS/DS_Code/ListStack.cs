using System;

namespace ProgrammingBasics_DS
{
    //LinkedList
    internal class ListStack 
    {
        private Node mylist = null;
        public int Count
        {

            get
            {
                Node curr = mylist;
                if (curr == null) return 0;
                int n = 1;
                while (curr.Next != null)
                {
                    curr = curr.Next;
                    n++;
                }
                return n;
            }
        }
        public int GetValueAt(int i)
        {
            Node curr = mylist;
            if (Count <= i || i < 0)
            {
                Console.WriteLine("Invalid index");
                return 0;
            }

            for (int x = 0; x < i; x++)
                curr = curr.Next;

            return curr.value;
        }
        public void Insert(int value)
        {
            if (mylist == null)
                mylist = new Node(value);
            else
            {

                Node NewNode = new Node(value);
                NewNode.Next = mylist;
                mylist = NewNode;
            }
        }
        public void InsertAt(int value, int Position)
        {

            if (mylist == null)
                if (Position == 0)
                    mylist = new Node(value);
                else
                { Console.WriteLine("Wrong Position"); return; }
            else if (Count < Position)
            { Console.WriteLine("Wrong Position"); return; }
            else
            {
                Node NewNode = new Node(value),
                    curr = mylist;
                for (int x = 0; x < Position - 1; x++)
                    curr = curr.Next;


                NewNode.Next = curr.Next;
                curr.Next = NewNode;
            }
        }
        public int RemoveAt(int Position)
        {

            if (mylist == null || Count + 1 < Position)
            { Console.WriteLine("Wrong Position"); return 0; }

            else
            {
                int value = 0;
                Node curr = mylist;
                for (int x = 0; x < Position - 1; x++)
                    curr = curr.Next;

                value = curr.Next.value;
                curr.Next = curr.Next.Next;
                return value;
            }
        }
        public int Remove()
        {
            if (mylist == null)
            { Console.WriteLine("Empty"); return 0; }
            else
            {
                int value = mylist.value;
                mylist = mylist.Next;
                return value;
            }
        }
        static void Main_LinkedList()
        {
            // ArrayStack a = new ArrayStack();
            ListStack l = new ListStack();
            //int v=  l.GetValueAt(0);
            for (int i = 10; i > 0; i--)
                l.Insert(i);

            l.InsertAt(50, 4);

            for (int i = 0; i < l.Count; i++)
                Console.WriteLine($"item[{i + 1}]={l.GetValueAt(i)}");

            int value = l.RemoveAt(4);

            for (int i = 0; i < l.Count; i++)
                Console.WriteLine($"item[{i + 1}]={l.GetValueAt(i)}");

        }
    }
    internal class Node
    {
        public Node(int Value) { value = Value; }
        internal int value;
        internal Node Next;
    }
}/* 
 * Educational Code
 * Dr. Amr Mausad @ 2024
 * http://amrmausad.com
 */
