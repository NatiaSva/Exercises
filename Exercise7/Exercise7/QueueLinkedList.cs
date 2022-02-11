using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    public class QueueLinkedList<T>
    {
        private Node<T> front;
        private Node<T> rear;
        private int count;


        public void Enqueue(T x)
        {
            Node<T> newNode = new Node<T>(x);
            if (front == null)
            {
                front = newNode;
                rear = front;
            }
            else
            {
                rear.Next = newNode;
                rear = rear.Next;
            }
            count++;
        }

        public T Dequeue()
        {
            if (front == null)
            {
                throw new Exception("Queue is empty");
            }

            T result = front.Value;
            front = front.Next;
            count--;
            return result;

        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("{");
            Node<T> node = front;
            for (int i = 0; i < count - 1; i++)
            {
                stringBuilder.Append(node.Value + ",");
                node = node.Next;
            }
            if (count > 0)
                stringBuilder.Append(node.Value);
            stringBuilder.Append("}");
            return stringBuilder.ToString();
        }

    }
}
