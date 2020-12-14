using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class Node2<T>
    {
        public T Data { get; set; }
        public Node2<T> Left { get; set; } = null;
        public Node2<T> Right { get; set; } = null;

        public Node2(T data)
        {
            Data = data;
        }
    }
    class DoublyLinkedList<T>
    {
        public int Length { get; set; }
        public bool Found { get; set; }
        Node2<T> Prev = null;
        Node2<T> Next = null;
        public Node2<T> First = null;
        public Node2<T> Last = null;
        Node2<T> Current = null;

        public DoublyLinkedList(T data)
        {
            Node2<T> head = new Node2<T>(data);
            First = head;
            Last = head;
            Length += 1; 
        }
            
        public void AddFirst(T data)
        {
            Node2<T> newNode = new Node2<T>(data);
            newNode.Right = First;
            First = newNode;
            Length += 1;
        }

        public void AddLast(T data)
        {
            Node2<T> newNode = new Node2<T>(data);
            Last.Right = newNode;
            newNode.Left = Last;            
            Last = newNode;
            Length += 1;
        }

        public void AddLeft(T data, Node2<T> node)
        {
            Node2<T> newNode = new Node2<T>(data);
            newNode.Right = node;
            newNode.Left = node.Left;
            if (node.Left!=null) {node.Left.Right = newNode;}           
            node.Left = newNode;
            if (newNode.Left == null) { First = newNode; }            
            Length += 1;
        }

        public void AddRight(T data, Node2<T> node)
        {
            Node2<T> newNode = new Node2<T>(data);
            newNode.Left = node;
            newNode.Right = node.Right;
            if (node.Right!= null) { node.Right.Left = newNode; }           
            node.Right = newNode;
            if (newNode.Right == null) { Last = newNode; }           
            Length += 1;
        }

        public void Find(T data)
        {
            var current = First;
            while(current.Right != null)
            {
                if (current.Data.Equals(data))
                {
                    Found = true;
                    Current = current;
                    return;
                }
                current = current.Right;
            }
            Found = false;
        }

        public void Print()
        {
            var current = First;
            for(int i=0; i<Length; i++)
            {
                Console.WriteLine("DoublyLinkedList Element {0}: {1}",i , current.Data);
                current = current.Right;
            }
        }

    }
}
