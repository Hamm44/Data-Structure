namespace ConsoleApp38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string words = "Abracadabra";
            word word = new word();
            Dictionary<char, int> dictionary = word.getChar(words);
            foreach (var c in dictionary)
            {
                Console.WriteLine($"{c.Key}: {c.Value}");
            }
        }
    }

    class word
    {
        public Dictionary<char, int> getChar(string strings)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char c in strings)
            {
                if (c == ' ')
                {
                    continue;
                }
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict[c] = 1;
                }
            }
            return dict;
        }
    }
}
