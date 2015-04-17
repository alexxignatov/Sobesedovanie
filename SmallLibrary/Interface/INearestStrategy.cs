using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallLibrary.Interface
{
    public interface INearestStrategy
    {
        int NearestTo(int[] array, int value);
    }
}
