using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
    public class Trojkat
    {
        private Linia l1, l2, l3;
        public Trojkat()
        {
            l1 = new Linia();
            l2 = new Linia();
            l3 = new Linia();
        }
        public Trojkat(Linia l1, Linia l2, Linia l3)
        {
            this.l1 = new Linia(l1);
            this.l2 = new Linia(l2);
            this.l3 = new Linia(l3);
        }
        public Trojkat(Trojkat trojkat)
        {
            l1 = new Linia(trojkat.l1);
            l2 = new Linia(trojkat.l2);
            l3 = new Linia(trojkat.l3);
        }
        public void przesun(int dx, int dy)
        {
            l1.przesun(dx, dy);
            l2.przesun(dx, dy);
            l3.przesun(dx, dy);
        }
        public override string ToString()
        {
            return l1.ToString() + ", " + l2.ToString() + ", " + l3.ToString();
        }
        public Linia getL1()
        {
            return l1;
        }

        public Linia getL2()
        {
            return l2;
        }

        public Linia getL3()
        {
            return l3;
        }
    }
}
