using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class BinarySearchTree<T> where T : IComparable
    {
        Node2<T> Head { get; set; }
        public int Count { get; set; }

        public BinarySearchTree(T data)
        {
            Head = new Node2<T>(data);
            Count += 1;
        }

        public void Grow(T data)
        {
            Node2<T> newNode = new Node2<T>(data);
            bool Added = false;
            AddNewElement(newNode, Head, ref Added);
        }

        public void AddNewElement(Node2<T> newNode, Node2<T> head, ref bool Added)
        {
            if (head == null || Added == true) { return; }

            if(head.Left==null && head.Data.CompareTo(newNode.Data)>=0)
            {
                head.Left = newNode;
                Count += 1;
                Added = true;
                Console.WriteLine("Inserted left {0}", newNode.Data);
                return;
            }

            if (head.Right == null && head.Data.CompareTo(newNode.Data) < 0)
            {
                head.Right = newNode;
                Count += 1;
                Added = true;
                Console.WriteLine("Inserted right {0}", newNode.Data);
                return;
            }
            AddNewElement(newNode, head.Left, ref Added);
            AddNewElement(newNode, head.Right, ref Added);
        }

        public void Print()
        {
            Console.Write("BST PreOrder Traversal:");
            PrintPreOrder(Head);
            Console.Write("\nBST PostOrder Traversal:");
            PrintPostOrder(Head);
            Console.Write("\nBST InOrder Traversal:");
            PrintInOrder(Head);
        }

        public void PrintPreOrder(Node2<T> head)
        {
            if(head == null) { return; }

            Console.Write("{0}{1}",head.Data,' ');
            PrintPreOrder(head.Left);
            PrintPreOrder(head.Right);
        }

        public void PrintPostOrder(Node2<T> head)
        {
            if (head == null) { return; }
            
            PrintPostOrder(head.Left);
            PrintPostOrder(head.Right);
            Console.Write("{0}{1}", head.Data, ' ');
        }

        public void PrintInOrder(Node2<T> head)
        {
            if (head == null) { return; }

            PrintInOrder(head.Left);
            Console.Write("{0}{1}", head.Data, ' ');
            PrintInOrder(head.Right);           
        }
    }
}
