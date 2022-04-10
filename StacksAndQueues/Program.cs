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

            Console.WriteLine("Choose\n 1:Stack\n 2:Queue\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    Stack stacks = new Stack();
                    stacks.Push(70);
                    stacks.Push(30);
                    stacks.Push(56);
                    stacks.Display();
                    stacks.IsEmopty();
                    stacks.Display();
                    break;
                case 2:
                    Queue queues = new Queue();
                    queues.Enqueue(56);
                    queues.Enqueue(30);
                    queues.Enqueue(70);
                    queues.Display();
                    break;
            }
            

            Console.ReadLine();
        }
    }
}
