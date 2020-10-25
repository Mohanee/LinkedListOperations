using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresDemo
{
    class Stack
    {

        LinkedList stackList = new LinkedList();

        internal void PushToStack(int data)
        {
            stackList.AddToFirst(data);
        }

        internal void DisplayStack()
        {
            stackList.Display();
        }

        internal void Peak_and_Pop_Stack()
        {
            Node temp = stackList.head;
            if (temp.next == null)
            {
                Console.WriteLine("Empty List");
            }
            else
            {
                while (temp.next != null)
                {
                    Console.WriteLine(Peak_Element());
                    Pop_Element();
                    stackList.Display();

                    temp = temp.next;
                    //Console.WriteLine("");
                }
            }
        }

        internal int Peak_Element()
        {
            int k = stackList.Return_Head();
            return k;
        }

        internal void Pop_Element()
        {
            stackList.Delete1stElement();
        }
    }
}
