using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresDemo
{
    class LinkedList
    {
        internal Node head;

        internal void AddToFirst(int data)
        {
            Node node = new Node(data);
            if(this.head== null)
            {
                this.head = node;
            }
            else
            {
                node.next = this.head;
            }
            this.head = node;
        }

        internal void AppendToLast(int data)
        {
            Node node = new Node(data);
            if(this.head==null)
            {
                this.head = node;
            }

            else
            {
                Node temp = head;
                while(temp.next!=null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            //Console.WriteLine("{0} inserted into the linked list", node.data);
        }

        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                if (temp.next != null)
                {
                    Console.Write(temp.data + " --> ");
                }
                else
                {
                    Console.Write(temp.data + " .");
                }
                temp = temp.next;
            }
            Console.WriteLine("\n\n");
        }


        internal void InsertAfter(int data2, int data)
        {
            Node newElement = new Node(data);
            if (this.head == null)
            {
                Console.WriteLine("The LL is Empty");
            }
            else
            {
                Node temp = this.head;
                bool flag = true;
                while (flag)
                {
                    if (temp.data == data2)
                    {
                        flag = false;
                    }
                    else
                    {
                        temp = temp.next;
                    }
                }
                newElement.next = temp.next;
                temp.next = newElement;
            }
        }

        internal void InsertInBetween(int pos, int data)
        {
            Node newElement = new Node(data);
            if (this.head == null)
            {
                Console.WriteLine("The LL is Empty");
            }
            else
            {
                Node temp = this.head;
                int tempPos = 0;
                bool flag = true;
                while (flag)
                {
                    tempPos++;
                    if (tempPos==pos)
                    {
                        flag = false;
                    }
                    else
                    {
                        temp = temp.next;
                    }
                }
                newElement.next = temp.next;
                temp.next = newElement;
            }
        }

        internal void Delete1stElement()
        {
            if(this.head== null)
            {
                Console.WriteLine("The LL is Empty");
            }
            else
            {
                head = this.head.next;
            }
            Console.WriteLine("\nNow the head is: " + this.head.data);
        }

        internal void DeleteLastElement()
        {
            if (this.head == null)
            {
                Console.WriteLine("The LL is Empty");
            }
            else
            {
                Node temp = this.head;
                while(temp.next.next != null)
                {
                    temp = temp.next;
                }
                temp.next = null;
            }
        }

        internal int SizeOfList()
        {
            int size = 0;
            if (this.head == null)
            {
                return 0;
            }
            else
            {
                Node temp = this.head;
                while(temp.next!=null)
                {
                    size++;
                    temp = temp.next;
                }
                return size+1;
            }

        }

        internal int SearchForAnElement(int data)
        {
            int pos = 0;

            if (this.head == null)
            {
                Console.WriteLine("The LL is Empty");
                return -1;
            }
            else
            {
                Node temp = this.head;
                bool flag = true;
                while (flag) 
                {
                    pos++;
                    if(temp.data == data)
                    {
                        flag = false;
                    }
                    else if(temp.next == null)
                    {
                        if(temp.data==data)
                        {
                            return pos;
                        }
                        else
                        {
                            flag = false;
                            pos++;
                        }
                    }
                    else
                    {
                        temp = temp.next;
                    }
                }
                if(pos==SizeOfList()+1)
                {
                    Console.WriteLine("Element not found in the list");
                    return 0;
                }
                return pos;
            }
        }

        
    }

}
