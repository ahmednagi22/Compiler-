using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    internal class parseStack
    {
        static readonly int MAX = 1000;
        int top;
        string[] stack = new string[MAX];

        internal bool IsEmpty()
        {
            return (top < 0);
        }
        public parseStack()
        {
            top = -1;
        }
        internal void Push(string data)
        {
            if (top >= MAX)
            {
                Console.WriteLine("Stack Overflow");

            }
            else
            {
                stack[++top] = data;

            }
        }

        internal string Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return null;
            }
            else
            {
                string value = stack[top--];
                return value;
            }
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
                    Console.WriteLine(stack[i]);
                }
            }


        }
    }
}
