using System;
using System.Linq;

namespace Dictionary
{
    public static class DictionaryExtensions
    {
        public static bool TryAdd<K, V>(this DefaultDictionary<K, V> dictionary, K key, V value)
        {
            if (dictionary.ContainsKey(key))
                return false;
            dictionary.Add(key, value);
            return true;
        }

        public static void PrintDictionary(this DefaultDictionary<string, int> dictionary)
        {
            foreach (var item in dictionary)
            {
                Console.WriteLine($"Key:{item.Key}, value:{item.Value}");
            }
        }

        public static void CountWords(this DefaultDictionary<string, int> dictionary)
        {
            var result = from words in dictionary
                         group words by words.Value into final
                         select new { Count = final.Count(), Value = final.Key };

            foreach (var value in result)
            {
                Console.WriteLine("Value = {0}, Count = {1}", value.Value, value.Count);
            }
        }
    }
}
