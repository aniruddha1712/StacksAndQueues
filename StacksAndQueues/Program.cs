using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Stacks And Queues Program\n");

            Stack stacks = new Stack();
            stacks.Push(70);
            stacks.Push(30);
            stacks.Push(56);
            stacks.Display();

            Console.ReadLine();
        }
    }
}
