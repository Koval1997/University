﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Lection : Lesson
    {
        public int PairNumber { get; private set; }

        public Lection(): base()
        {
        }
    }
}