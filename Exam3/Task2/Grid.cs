﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Grid<T> where T : struct
    {
        private T[,,] _grid;
    }
}
