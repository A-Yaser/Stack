using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Stack<T>
    {
        int size;
        object[] ArrayStack;
        int top;
        public Stack(int size)
        {
            this.size = size;
            ArrayStack = new object[this.size];
            this.top = -1;
           
        }

        public void push(object newItem)//this mithod for addElmante to stack
        {
            if (isfull())
            {
                Console.WriteLine(" ERROR!! \nYou can not add any element; the stack is full, \n the elemnt did not added to stack");
            }
            else { 
            top ++;
            ArrayStack[top]= newItem;
            }
        }

        public void pup()//this mithod for addElmante to stack
        {
            if (isempty())
            {
                Console.WriteLine(" ERROR!! \n the stack is empty");
            }
            else
            {
                ArrayStack[top] = "";
                top--;
            }
           

        }

        public bool isfull()
        {
            return (top == size-1);
        }

        public bool isempty()
        {
            return (top == -1);
        }

        public void test()
        {
            if (isempty())
            {
                Console.WriteLine(" ERROR!! \n the stack is empty");
            }
            else
            {
                Console.WriteLine(this.ArrayStack[top]);
            }
            
        }
    }
}
