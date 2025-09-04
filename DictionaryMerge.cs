namespace ConsoleApp39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dictionary dict = new dictionary();
            dict.mergeDictionary();
        }
    }

    class dictionary
    {
        public void mergeDictionary()
        {
            Dictionary<string, int> dictionary1 = new Dictionary<string, int> { { "First", 10 }, { "Second", 12 }, { "Third", 15 } };
            Dictionary<string, int> dictionary2 = new Dictionary<string, int> { { "Null", 11 }, { "Second", 12 }, { "Third", 15 } };
            foreach (var c in dictionary1)
            {
                if (dictionary2.ContainsKey(c.Key))
                {
                    dictionary2[c.Key] += c.Value;
                }
                else
                {
                    dictionary2[c.Key] = c.Value;
                }
            }
            foreach (var c in dictionary2)
            {
                Console.WriteLine($"{c.Key}, {c.Value}");
            }
        }
    }
}
