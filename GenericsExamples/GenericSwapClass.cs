using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExamples
{
    class GenericSwapClass
    {
        public void SwapFunction<T>(ref T item1, ref T item2)
        {
            T temporaryValue;
            temporaryValue = item1;
            item1 = item2;
            item2 = temporaryValue;
        }
    }
}
