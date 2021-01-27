using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; } = null;
        public Node(T data)
        {
            this.Data = data;
        }
    }
    class SinglyLinedList<T>
    {
        public int Length = 0;
        public bool found = false;
        Node<T> First { get; set; } = null;
        Node<T> Last { get; set; } = null;
        Node<T> prev { get; set; } = null;
        Node<T> Current { get; set; } = null;

        public SinglyLinedList (T data)
        {
            Node<T> head = new Node<T>(data);
            First = head;
            Last = head;
            Length += 1;
        }

        public void AddFirst(T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.Next = this.First;
            this.First = newNode;
            Length += 1;
        }

        public void AddLast(T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.Next = null;
            this.Last.Next = newNode;
            this.Last = newNode;
            Length += 1;
        }

        public void Find(T data)
        {
            var current = First;
            while(current.Next!=null)
            {
                if (current.Data.Equals(data))
                {
                    Current = current;
                    found = true;
                    break;
                }
                prev = current;
                current = current.Next;
                found = false;
            }
        }

        public void Remove(T data)
        {
            Find(data);
            if(found)
            {
                this.prev.Next = this.Current.Next;
                this.Current.Next = null;
                Length -= 1;
            }
        }
        public void Print()
        {
            var current = First;
            for (int i = 0; i < Length; i++)
            {
                Console.WriteLine("Element {0}:{1}", i, current.Data);
                current = current.Next;
            }
        }
    }
}
