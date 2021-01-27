using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinedList<int> singlyLinedList = new SinglyLinedList<int>(0);
            singlyLinedList.AddFirst(-10);
            singlyLinedList.AddLast(10);
            singlyLinedList.AddFirst(-20);
            singlyLinedList.AddLast(20);
            singlyLinedList.Print();
            singlyLinedList.Find(-10);
            Console.WriteLine("-10 found:{0}", singlyLinedList.found);
            singlyLinedList.Find(-40);
            Console.WriteLine("-40 found:{0}", singlyLinedList.found);
            singlyLinedList.Remove(-10);
            singlyLinedList.Print();

            DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>(0);
            doublyLinkedList.AddFirst(1);
            doublyLinkedList.AddLast(2);
            doublyLinkedList.AddLeft(3, doublyLinkedList.First);
            doublyLinkedList.AddRight(4, doublyLinkedList.First);
            doublyLinkedList.AddFirst(5);
            doublyLinkedList.AddLast(6);
            doublyLinkedList.AddLeft(7, doublyLinkedList.First);
            doublyLinkedList.AddRight(8, doublyLinkedList.First);
            doublyLinkedList.AddFirst(9);
            doublyLinkedList.AddLast(10);
            doublyLinkedList.AddLeft(11, doublyLinkedList.First);
            doublyLinkedList.AddRight(12, doublyLinkedList.First);
            doublyLinkedList.Print();
            Console.WriteLine("Length: {0}",doublyLinkedList.Length);
            doublyLinkedList.Find(7);
            Console.WriteLine("7 found:{0}", doublyLinkedList.Found);

            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>(100);
            binarySearchTree.Grow(90);
            binarySearchTree.Grow(110);
            binarySearchTree.Grow(85);
            binarySearchTree.Grow(120);
            binarySearchTree.Grow(140);
            binarySearchTree.Grow(10);
            binarySearchTree.Grow(85);
            Console.WriteLine("Tree Elements Count: {0}", binarySearchTree.Count);
            binarySearchTree.Print();
        }
    }
}
