using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Grid<T> where T : struct
    {
        public Grid(int p, int q, int r) { 
            _grid= new T[p, q, r];
        }
        private T[,,] _grid;
        public T this[int x, int y, int z]
        {
            get
            {
                return _grid[x, y, z];
            }
            set 
            { 
                _grid[x, y, z]= value;
            }
        }
    }
}
