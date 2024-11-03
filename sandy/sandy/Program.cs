using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddFirst(1);
            list.AddLast(2);
            list.AddAtPosition(3, 1);

            list.PrintList(); // Output: 1 - 3 - 2 - null

            list.RemoveFirst();
            list.RemoveLast();

            list.PrintList(); // Output: 3 - null
        }
    }//انشاء صف معمم
    public class Node<T>
    {
        public T Data;
        public Node<T> Next;

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    public class LinkedList<T>
    {
        private Node<T> head;

        public LinkedList()
        {
            head = null;
        }
        //اضافة من بداية
        public void AddFirst(T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.Next = head;
            head = newNode;
        }
        //اضافة من نهاية
        public void AddLast(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node<T> current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }
        //تحديد موقع
        public void AddAtPosition(T data, int position)
        {
            if (position < 0) throw new ArgumentOutOfRangeException(nameof(position));
            Node<T> newNode = new Node<T>(data);
            if (position == 0)
            {
                newNode.Next = head;
                head = newNode;
            }
            else
            {
                Node<T> current = head;
                for (int i = 1; i < position && current != null; i++)
                {
                    current = current.Next;
                }
                if (current == null) throw new ArgumentOutOfRangeException(nameof(position));
                newNode.Next = current.Next;
                current.Next = newNode;
            }
        }
        //حذف من بداية 
        public void RemoveFirst()
        {
            if (head != null)
            {
                head = head.Next;
            }
        }
        //حذف من نهاية

        public void RemoveLast()
        {
            if (head == null) return;
            if (head.Next == null)
            {
                head = null;
            }
            else
            {
                Node<T> current = head;
                while (current.Next.Next != null)
                {
                    current = current.Next;
                }
                current.Next = null;
            }
        }
        //
        public void PrintList()
        {
            Node<T> current = head;
            while (current != null)
            {
                Console.Write(current.Data + " - ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }
    }

}



