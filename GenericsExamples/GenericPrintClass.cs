using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExamples
{
        public class GenericPrintClass<T>
        {
            T value;

            public GenericPrintClass(T itemToPrint)
            {

                value = itemToPrint;
            }

            public void Print()
            {
                Console.WriteLine(value);
            }
        }
    
  }
