using CustomQueue;
using System;

class Program
{
    static void Main(string[] args)
    {
   
        CustomQueue<int> queue = new CustomQueue<int>();

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Enqueue(5);

        Console.WriteLine("Dequeued items :");
        while (queue.Count > 0)
        {
            int item = queue.Dequeue();
            Console.WriteLine(item);
        }

        // queue of strings with capacity of 3
        CustomQueue<string> queueWithCapacity = new CustomQueue<string>(3);


        queueWithCapacity.Enqueue("one");
        queueWithCapacity.Enqueue("two");
        queueWithCapacity.Enqueue("three");

      
        queueWithCapacity.Enqueue("four");

    

        string frontItem = queueWithCapacity.Peek();
        Console.WriteLine("Peeked item : " + frontItem);

        queueWithCapacity.Clear();
        Console.WriteLine("Count: " + queueWithCapacity.Count);
    }
}

