using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //Queue
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

        Console.WriteLine("---------------------------------");
        
        //Priority Queue
        PriorityQueue<int,int> priorityQueue = new PriorityQueue<int,int>();

        priorityQueue.Enqueue(3, 3);
        priorityQueue.Enqueue(1, 1);
        priorityQueue.Enqueue(4, 4);
        priorityQueue.Enqueue(2, 2);
        priorityQueue.Enqueue(5, 5);

        while (priorityQueue.Count > 0)
        {
            int highestPriorityItem = priorityQueue.Dequeue();
            Console.WriteLine($"Highest priority item: {highestPriorityItem}");
        }

        Console.WriteLine("---------------------------------");

        //Stack
        Stack<string> stack = new Stack<string>();

        stack.Push("item 1");
        stack.Push("item 2");
        stack.Push("item 3");
        stack.Push("item 4");
        stack.Push("item 5");

        if (stack.Contains("item 3"))
        {
            Console.WriteLine("Stack contains item 3.");
        }
        else
        {
            Console.WriteLine("Stack does not contain item 3.");
        }

        stack.Pop();

        int count = stack.Count;
        Console.WriteLine($"Stack contains {count} items.");

        Console.WriteLine("Stack items:");
        foreach (string i in stack)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("---------------------------------");

        //LinkedList
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

        Console.WriteLine("---------------------------------");

        //Dictionary
        Dictionary<string, string> dictionary = new Dictionary<string, string>();

        dictionary.Add("key1", "value1");
        dictionary.Add("key2", "value2");
        dictionary.Add("key3", "value3");
        dictionary.Add("key4", "value4");
        dictionary.Add("key5", "value5");

        Console.WriteLine("Dictionary keys:");
        foreach (string k in dictionary.Keys)
        {
            Console.WriteLine(k);
        }

        Console.WriteLine("Dictionary values:");
        foreach (string value in dictionary.Values)
        {
            Console.WriteLine(value);
        }

        Console.WriteLine("Dictionary keys and values:");
        foreach (KeyValuePair<string, string> kvp in dictionary)
        {
            Console.WriteLine($"{kvp.Key} => {kvp.Value}");
        }

        dictionary.Remove("key3");

        int dictCount = dictionary.Count;
        Console.WriteLine($"Dictionary contains {count} items.");

        Console.WriteLine("---------------------------------");

        //SortedList
        SortedList<int, string> sortedList = new SortedList<int, string>();

        sortedList.Add(3, "value3");
        sortedList.Add(1, "value1");
        sortedList.Add(5, "value5");
        sortedList.Add(2, "value2");
        sortedList.Add(4, "value4");

        Console.Write("Enter a key: ");
        int key = int.Parse(Console.ReadLine());
        if (sortedList.ContainsKey(key))
        {
            Console.WriteLine("Key already exists.");
        }
        else
        {
            Console.Write("Enter a value: ");
            string value = Console.ReadLine();
            sortedList.Add(key, value);
        }

        Console.Write("Enter a key to remove: ");
        int keyToRemove = int.Parse(Console.ReadLine());
        if (sortedList.ContainsKey(keyToRemove))
        {
            sortedList.Remove(keyToRemove);
        }
        else
        {
            Console.WriteLine("Key does not exist.");
        }

        foreach (KeyValuePair<int, string> kvp in sortedList)
        {
            Console.WriteLine($"{kvp.Key} => {kvp.Value}");
        }

        Console.WriteLine("---------------------------------");

        //Hashset
        HashSet<int> set1 = new HashSet<int>() { 1, 2, 3, 4, 5 };
        HashSet<int> set2 = new HashSet<int>() { 4, 5, 6, 7, 8 };
        HashSet<int> set3 = new HashSet<int>() { 5, 6, 9, 10, 11 };

        set1.UnionWith(set2);

        Console.WriteLine("Combined set1 and set2:");
        foreach (int i in set1)
        {
            Console.WriteLine(i);
        }

        HashSet<int> duplicates = new HashSet<int>(set1);
        duplicates.IntersectWith(set3);

        Console.WriteLine("Duplicates between set1 and set3:");
        foreach (int i in duplicates)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("---------------------------------");

        //List
        List<string> myList = new List<string>() { "apple", "banana", "cherry", "date", "elderberry" };

        myList.AddRange(new string[] { "fig", "grape", "honeydew" });

        myList.Sort();
        Console.WriteLine("Sorted list:");
        foreach (string i in myList)
        {
            Console.WriteLine(i);
        }

        myList.Remove("cherry");

        myList.Reverse();
        Console.WriteLine("Reverse sorted list:");
        foreach (string i in myList)
        {
            Console.WriteLine(i);
        }
    }
}
