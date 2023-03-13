using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<int> queue = new Queue<int>();

        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);
        queue.Enqueue(40);
        queue.Enqueue(50);

        Console.WriteLine($"The queue {(queue.Contains(30) ? "Contains" : "Does not contain")} 30");

        int item = queue.Dequeue();
        Console.WriteLine("Removed item from queue: " + item);

        Console.WriteLine("Queue count: " + queue.Count);

        Console.WriteLine("Queue items:");
        foreach (int i in queue)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine();

        LinkedList<string> linkedList = new LinkedList<string>();

        linkedList.AddLast("apple");
        linkedList.AddLast("banana");
        linkedList.AddLast("cherry");
        linkedList.AddLast("date");
        linkedList.AddLast("elderberry");

        LinkedListNode<string> firstNode = linkedList.First;
        Console.WriteLine("First node: " + firstNode.Value);

        LinkedListNode<string> lastNode = linkedList.Last;
        Console.WriteLine("Last node: " + lastNode.Value);

        linkedList.AddAfter(linkedList.Find("cherry"), "durian");

        linkedList.Remove("banana");

        Console.WriteLine("Linked list count: " + linkedList.Count);

        Console.WriteLine("Linked list items:");
        foreach (string s in linkedList)
        {
            Console.WriteLine(s);
        }
    }
}
