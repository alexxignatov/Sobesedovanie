using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallLibrary.Interface
{
    public interface IEasyTask
    {
        string Reverse(string s);
        void Sort(int[] numbers);
        int NearestTo(int[] array, int number);
    }
}
