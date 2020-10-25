using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresDemo
{
    class Queue
    {
        LinkedList qList = new LinkedList();

        internal void Enqueue(int data)
        {
            qList.AppendToLast(data);
        }

        internal void DisplayQueue()
        {
            qList.Display();
        }

        internal void Dequeue()
        {
            Console.WriteLine(qList.DeleteLastElement());
        }
    }
}
