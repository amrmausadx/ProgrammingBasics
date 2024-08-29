using System;


namespace ProgrammingBasics_DS
{
    //stack using array
    internal class StackArray
    {
        static int MAX;
        int[] stackarray;
        int top;
        public StackArray()
        {
            top = -1;
            Console.Write("please enter size of stack : ");
            MAX = int.Parse(Console.ReadLine());
            stackarray = new int[MAX];
        }
        bool IsEmpty()
        {
            return (top < 0);
        }
        bool IsFull()
        {
            return (top == stackarray.Length - 1);
        }
        internal void Push()
        {
            if (IsFull())
            {
                Console.WriteLine("Stack Overflow");
            }
            else
            {
                top++;
                Console.Write("Enter the Pushed item: ");
                stackarray[top] = int.Parse(Console.ReadLine());
            }
        }
        internal void Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack Underflow");
            }
            else
            {
                int value = stackarray[top--];
                Console.WriteLine("The Poped item is " + value);
            }
        }
        internal void Peek()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
                Console.WriteLine("The topmost element of Stack is : {0}",
                stackarray[top]);
        }
        internal void PrintStack()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("Items in the Stack are :");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stackarray[i]);
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