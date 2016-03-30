﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generic Print Example Starts Here
            GenericPrintClass<int> genericTestInt = new GenericPrintClass<int>(16);
            Console.WriteLine("Generic Class Test used with an Int");
            genericTestInt.Print();
            Console.ReadKey();
            GenericPrintClass<string> genericTestString = new GenericPrintClass<string>("Packers");
            Console.WriteLine("Generic Class Test used with a string");
            genericTestString.Print();
            Console.ReadKey();
            // Generic Swap Class Example Starts Here
            GenericSwapClass swap = new GenericSwapClass();
            Console.WriteLine("Using Generic Swap Method");
            int FirstIntForSwap = 4;
            int SecondIntForSwap = 12;
            Console.WriteLine("First Int For Swap Value: {0} \r\n", FirstIntForSwap);
            Console.WriteLine("Second Int For Swap Value: {0} \r\n", SecondIntForSwap);
            Console.WriteLine("Using Generic Swap Method to Swap Ints");
            Console.ReadKey();
            swap.SwapFunction<int>(ref FirstIntForSwap, ref SecondIntForSwap);
            Console.WriteLine("After the Int Swap ");
            Console.WriteLine("First Int For Swap Value: {0}  \r\n", FirstIntForSwap);
            Console.WriteLine("Second Int For Swap Value: {0} \r\n", SecondIntForSwap);
            Console.ReadKey();
            string FirstStringForSwap = "This is the first string";
            string SecondStringForSwap = "This is the second string";
            Console.WriteLine("Before the String Swap ");
            Console.WriteLine("First String For Swap Value: {0} \r\n", FirstStringForSwap);
            Console.WriteLine("Second String For Swap Value: {0} \r\n", SecondStringForSwap);
            Console.ReadKey();
            swap.SwapFunction<string>(ref FirstStringForSwap, ref SecondStringForSwap);
            Console.WriteLine("After The String Swap");
            Console.WriteLine("First String for Swap Value: {0} \r\n", FirstStringForSwap);
            Console.WriteLine("Second String for Swap Value: {0} \r\n", SecondStringForSwap);
            Console.ReadKey();


        }
   }
}

