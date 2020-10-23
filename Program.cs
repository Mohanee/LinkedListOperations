using System;

namespace DataStructuresDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList list = new LinkedList();
            bool cont = true;
            while (cont)
            {
                Console.WriteLine("Choose among the following LinkedList Operation:\n1.Create LL\t2.Add To First\t3.Append To Last\n4.Insert at a particular position\t5.Delete 1st Element\t6.Delete Last Element\t7.Search for an Element\n8.Add after an Element\t9.DElete after an Element\t10.Sort the LL\t11.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        list.AddToFirst(70);
                        list.Display();
                        break;

                    case 2:
                        list.AddToFirst(30);
                        list.AddToFirst(56);
                        list.Display();
                        break;

                    case 3:
                        list.AppendToLast(45);
                        list.AppendToLast(35);
                        list.AppendToLast(67);
                        list.AppendToLast(100);
                        list.Display();
                        break;

                    case 4:
                        list.InsertInBetween(4, 78);
                        list.Display();
                        break;

                    case 5:
                        list.Delete1stElement();
                        list.Display();
                        break;

                    case 6:
                        list.DeleteLastElement();
                        list.Display();
                        break;

                    case 7:
                        Console.WriteLine("Enter the element to search for: ");
                        int k = Convert.ToInt32(Console.ReadLine());
                        int s = list.SearchForAnElement(k);
                        if (s >= 1)
                        {
                            Console.WriteLine("Element is found at position " + s);
                        }
                        break;

                    case 8:
                        list.InsertAfter(45, 89);
                        list.Display();
                        break;

                    case 9:
                        Console.WriteLine("Enter the element to be deleted ");
                        int del = Convert.ToInt32(Console.ReadLine());
                        int ifPresent = list.SearchForAnElement(del);
                        if (ifPresent >= 1)
                        {
                            list.DeleteElement(del);
                            list.Display();
                        }
                        break;

                    case 10:
                        list.sortLL();
                        list.Display();
                        break;

                    case 11:
                        cont = false;
                        break;

                    default: break;
                }
            }
        }
    }
}

  