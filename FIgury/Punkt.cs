using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
    public class Punkt
    {
        private int x, y;
        public Punkt()
        {
            x = 0;
            y = 0;
        }
        public Punkt(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Punkt(Punkt punkt)
        {
            x = punkt.x;
            y = punkt.y;
        }
        public void przesun(int dx, int dy)
        {
            x += dx;
            y += dy;
        }
        public override string ToString()
        {
            return "(" + x + "," + y + ")"; 
        }
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
    }
}
