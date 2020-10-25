using System;

namespace DataStructuresDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the Data Structure to perform operations:\n1.Linked List\t2.Stack using LL\t3.Queue using LL");
            int choice = Convert.ToInt32(Console.ReadLine());
            if(choice==1)
            {
                LLOperations llopr = new LLOperations();
                llopr.PerformLLOperations();
            }
            if(choice == 2)
            {
                StackOperation sopr = new StackOperation();
                sopr.PerformStackOperation();
            }
            if(choice == 3)
            {
                QueueOperations qopr = new QueueOperations();
                qopr.PerformQueueOperations();
            }
        }
    }
}

  