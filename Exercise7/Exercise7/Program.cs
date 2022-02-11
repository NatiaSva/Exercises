using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueLinkedList<int> q = new QueueLinkedList<int>();

            q.Enqueue(5);
            q.Enqueue(7);
            q.Enqueue(6);
            q.Enqueue(3);
            Console.WriteLine(q.ToString());
            q.Dequeue();
            Console.WriteLine(q.ToString());
        }
    }
}
