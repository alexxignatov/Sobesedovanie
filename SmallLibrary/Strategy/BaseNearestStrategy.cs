using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmallLibrary.Interface;

namespace SmallLibrary.Strategy
{
    public class BaseNearestStrategy : INearestStrategy
    {
        public int NearestTo(int[] array, int value)
        {
            if (array == null)
                throw new ArgumentNullException();
            if (array.Length == 0)
                throw new ArgumentException();
            
            int nearest = 0;
            int minDifference = Math.Abs(array[0] - value);

            foreach (var item in array)
            {
                var currentDifference = Math.Abs(item - value);

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
