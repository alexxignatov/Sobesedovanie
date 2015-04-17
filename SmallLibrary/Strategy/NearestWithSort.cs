using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmallLibrary.Interface;

namespace SmallLibrary.Strategy
{
    public class NearestWithSort : INearestStrategy
    {
        public int NearestTo(int[] array, int value)
        {
            if (array == null)
                throw new ArgumentNullException();
            if (array.Length == 0)
                throw new ArgumentException();

            return array.ToList().OrderBy(v => Math.Abs(v - value)).First();
        }
    }
}
