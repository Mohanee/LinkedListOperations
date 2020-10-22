﻿using System;
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
        }
    }

}
