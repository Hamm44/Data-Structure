using System.ComponentModel;

namespace ConsoleApp37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList mylist = new MyList();
            foreach (var item in mylist.getInfo())
            {
                Console.Write(item);
            }
            Console.WriteLine();
            foreach (var remove in mylist.removeValue(mylist.getInfo()))
            {
                Console.WriteLine(remove);
            }
            Console.WriteLine();
            foreach (var removeAt in mylist.removeAt(mylist.getInfo()))
            {
                Console.WriteLine(removeAt);
            }
            bool n = mylist.contains(mylist.getInfo());
            Console.WriteLine(n);
        }
    }

    class MyList
    {
        public List<int> getInfo()
        {
            List<int> list = new List<int> { 1, 2, 3, 4 };


            return list;
        }

        public List<int> removeValue(List<int> ints)
        {
            ints.Remove(3);
            return ints;

        }

        public List<int> removeAt(List<int> at)
        {
            at.RemoveAt(1);
            return at;
        }

        public bool contains(List<int> cont)
        {
            return cont.Contains(1);
            
        }
    }
}
