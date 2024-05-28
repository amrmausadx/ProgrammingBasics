using System;


namespace ProgrammingBasics_DS
{
    //Queue using array
    internal class QueueArray
    {
        static int MAX;
        int[] Queue;
        int rear, front;
        public QueueArray()
        {
            rear = front = -1;
            Console.Write("please enter size of queue : ");
            MAX = int.Parse(Console.ReadLine());
            Queue = new int[MAX];
        }
        bool IsEmpty()
        {

            return (front < 0) || front > rear;
        }
        internal void enqueu()
        {
            if (rear == Queue.Length - 1)
            {
                Console.WriteLine("queue Overflow");
            }
            else
            {
                if (front == -1)
                {
                    front++;
                }
                rear++;
                Console.Write("Enter the Added item: ");
                Queue[rear] = int.Parse(Console.ReadLine());
            }

        }
        internal void deque()
        {
            if (IsEmpty()) //(front==-1||front>rear)
            {
                Console.WriteLine("Queue Underflow");
            }
            else
            {
                int value = Queue[front++];
                Console.WriteLine("The removed item is " + value);
                if (front > rear)
                {
                    front = rear = -1;
                }
            }
        }
        internal void Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue Underflow");
                return;
            }
            else
                Console.WriteLine("The last element of queue is : {0}",
                Queue[rear]);
        }
        internal void PrintQueue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue Underflow");
                return;
            }
            else

            {
                Console.WriteLine("Items in the Queue are :");
                for (int i = front; i <= rear; i++)
                {
                    Console.WriteLine(Queue[i]);
                }
            }
        }
    }
}
/* 
 * Educational Code
 * Dr. Amr Mausad @ 2024
 * http://amrmausad.com
 */