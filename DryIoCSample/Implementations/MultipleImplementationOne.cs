﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DryIoCSample
{
    public class MultipleImplementationOne : IMultipleImplementations
    {
        public void Print()
        {
            Console.WriteLine("I am one implementation");
        }
    }
}
