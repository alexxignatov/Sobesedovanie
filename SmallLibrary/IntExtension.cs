using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmallLibrary.Interface;

namespace SmallLibrary
{
    public static class IntExtension
    {
        /// <summary>
        /// Extension method that can use different strategies to find nearest value
        /// </summary>
        public static int NearestTo(this int[] array, int value, INearestStrategy strategy)
        {
            return strategy.NearestTo(array, value);
        }
    }
}
