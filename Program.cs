using System;

namespace DataStructuresDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedList list = new LinkedList();
            list.AddToFirst(70);
            list.AddToFirst(30);
            list.AddToFirst(56);

            list.AppendToLast(45);
            list.InsertInBetween(30, 78);
            list.AppendToLast(35);

            Console.WriteLine("The linked List is -->");
            list.Display();
            list.Delete1stElement();
            Console.WriteLine("New LL after Deleting first element");
            list.Display();
            Console.ReadKey();
        }
    }
}
 