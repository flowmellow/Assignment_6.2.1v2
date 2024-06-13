/*
Write a C# program to implement a stack by using array with push and pop operations.
*/

namespace Assignment_6._2._1v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 22 };
            Stack myStack = new Stack();

            Console.WriteLine("These are the numbers pushed to the stack: ");
            foreach (int i in nums)
            {
                myStack.Push(i);
                Console.WriteLine(i);               
            }
            Console.WriteLine();

            Console.WriteLine("This is a peek at the top of the stack: " + myStack.Peek());
            Console.WriteLine();

            Console.WriteLine("These are the numbers popped from the stack in LIFO: ");
            while (!myStack.IsEmpty())
            {
                int poppedElement = myStack.Pop();  
                Console.WriteLine(poppedElement);
            }       
            
        }
    }

    class Stack
    {
        
        int top = -1; // needed -1 to show an empty stack. If not initialized ie int top; You must go to IsEmpty() method and change return to return <= 0;
        int[] stack = new int[10]; // assigned the stack max element assignment of 10. 

        internal void Push(int data)
        {
            if (top >= stack.Length)
            {
                Console.WriteLine("Stack Overflow");
                //return false; removed due to change from bool to void

            }
            else
            {
                stack[++top] = data;
                //return true; removed due to change from bool to void
            }
        }

        internal int Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return 0;
            }
            else
            {
                int value = stack[top--];
                return value;
            }
        }

        internal int Peek()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return 0;
            }
            else
            {
                return stack[top];
                
            }
        }

        internal bool IsEmpty()
        {
            return top < 0;
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
                Console.WriteLine("Items in the stack are: ");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
    }
}
