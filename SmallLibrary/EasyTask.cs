using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmallLibrary.Interface;

namespace SmallLibrary
{
    public class EasyTask : IEasyTask
    {
        public string Reverse(string s)
        {
            if (s == null)
                throw new ArgumentNullException();

            StringBuilder sb = new StringBuilder(s.Length);

            for (int i = s.Length - 1; i >= 0; i--)
            {
                sb.Append(s[i]);
            }

            return sb.ToString();
        }

        public void Sort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
        }


        public string[] MostPopular(string input, int count)
        {
            if (input == null)
                throw new ArgumentNullException();

            string[] allWords = input.Split(' ');
            if(allWords.Length <= 0)
                throw new ArgumentException();

            Dictionary<string, int> rating = new Dictionary<string, int>();

            foreach (var word in allWords)
            {
                if(rating.ContainsKey(word))
                    rating[word]++;
                else
                {
                    rating.Add(word, 1);
                }
            }

            return SortDescByValue(rating).Take(count).Select( v => v.Key).ToArray();
        }

        private List<KeyValuePair<string,int>> SortDescByValue(Dictionary<string, int> input)
        {
            var list = input.ToList();
            list.Sort((first, next) => { return next.Value.CompareTo(first.Value); });

            return list;
        }
    }
}
