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
            list.AppendToLast(35);

            Console.WriteLine("The linked List is -->");
            list.Display();
            Console.ReadKey();
        }
    }
}
