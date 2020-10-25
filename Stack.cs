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
    }
}
