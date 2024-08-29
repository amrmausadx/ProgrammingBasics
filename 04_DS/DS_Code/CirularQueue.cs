using System;

namespace ProgrammingBasics_DS
{
    //circular queue ده طبقناه فى السكشن
    internal class CirularQueue
    {
        static int MAX;
        int[] Queue;
        int rear, front;
        public CirularQueue()
        {
            rear = front = -1;
            Console.Write("please enter size of queue : ");
            MAX = int.Parse(Console.ReadLine());
            Queue = new int[MAX];
        }
        bool IsEmpty()
        {
            return (front < 0);
        }
        internal void enqueu()
        {
            if (((rear + 1) % Queue.Length) == front)
            {
                Console.WriteLine("queue Overflow");
            }
            else
            {
                if (front == -1)
                {
                    front++;
                }
                rear = (rear + 1) % MAX;
                Console.Write("Enter the Pushed item: ");
                Queue[rear] = int.Parse(Console.ReadLine());
            }
        }
        internal void deque()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue Underflow");
            }
            else
            {
                int value = Queue[front];
                Console.WriteLine("The removed item is " + value);

                if (front == rear)
                {
                    front = rear = -1;
                }
                else
                {
                    front = (front + 1) % MAX;
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
                Console.WriteLine("The topmost element of queue is : {0}", Queue[rear]);
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
                if (front <= rear)
                {
                    Console.WriteLine("Items in the Queue are :");
                    for (int i = front; i <= rear; i++)
                    {
                        Console.WriteLine(Queue[i]);
                    }
                }
                else
                {
                    Console.WriteLine("Items in the Queue are :");
                    for (int i = front; i <= MAX - 1; i++)
                    {
                        Console.WriteLine(Queue[i]);
                    }
                    for (int i = 0; i <= rear; i++)
                    {
                        Console.WriteLine(Queue[i]);
                    }
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
