using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresDemo
{
    class QueueOperations
    {
        public void PerformQueueOperations()
        {
            Queue q = new Queue();
            bool val = true;
            while (val)
            {
                Console.WriteLine("Choose the operation to perform\n1.Enqueue\t2.Dequeue\t3.Exit\n");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        q.Enqueue(70);
                        q.Enqueue(30);
                        q.Enqueue(56);
                        q.Enqueue(100);
                        q.Enqueue(34);
                        q.Enqueue(45);
                        q.DisplayQueue();
                        break;

                    case 2:
                        q.Dequeue();
                        q.DisplayQueue();
                        break;

                    case 3:
                        val = false;
                        break;

                    default: break;
                }
            }
        }
    }
}
