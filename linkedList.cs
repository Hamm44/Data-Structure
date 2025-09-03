using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp36
{
    namespace G08_20251406
    {
        internal class Program
        {
            static void Main()
            {
                MyNode mynod1 = new MyNode(15);
                MyNode mynod2 = new MyNode(17);
                MyNode mynod3 = new MyNode(18);
                mynod1.Next = mynod2;
                mynod2.Next = mynod3;
                MyNode current = mynod1;
                while (current != null)
                {
                    Console.WriteLine(current.Data);
                    current = current.Next;
                }
            }
        }

        class MyNode
        {
            public int Data;
            public MyNode Next;

            public MyNode(int data)
            {
                Data = data;
                Next = null;
            }
        }
        class SingleList
        {
            public MyNode first;
            public void addNode(int data)
            {
                MyNode node = new MyNode(data);
                if (first == null)
                {
                    first = node;
                }
                MyNode current = first;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = node;
            }
        }
    }
}

