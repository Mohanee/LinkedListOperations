using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresDemo
{
    class StackOperation
    {
        public void PerformStackOperation()
        {
            Stack s = new Stack();
            bool val = true;
            while (val)
            {
                Console.WriteLine("Choose the operation to perform\n1.Push\t2.Peak & Pop the whole list\t3.Exit\n");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        s.PushToStack(70);
                        s.PushToStack(30);
                        s.PushToStack(56);
                        s.PushToStack(45);
                        s.PushToStack(100);
                        s.DisplayStack();
                        break;

                    case 2:
                        s.Peak_and_Pop_Stack();
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
