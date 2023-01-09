using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>(5);
            stack.push("this is first item");
            stack.push("this is 2 item");
            stack.push("this is 3 item");
            stack.push("this is 4 item");
            stack.push("this is 5 item");
            stack.push("this is 5 item");
            stack.pup();
            stack.pup();
            stack.pup();
            stack.pup();
            stack.pup();

            stack.test();
            Console.WriteLine(stack.isempty());
            Console.WriteLine(stack.isfull());

        }
        
    }
}
