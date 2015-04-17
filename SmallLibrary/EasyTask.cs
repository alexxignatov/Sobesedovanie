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

        public int NearestTo(int[] array, int number)
        {
            if(array == null)
                throw new ArgumentNullException();
            if (array.Length == 0)
                throw new ArgumentException();

            int nearest = 0;
            int minDifference = Math.Abs(array[0] - number);

            foreach (var item in array)
            {
                var currentDifference = Math.Abs(item - number);

                if (currentDifference < minDifference)
                {
                    minDifference = currentDifference;
                    nearest = item;
                }
            }

            return nearest;
        }
    }
}
