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
        }
    }
}
