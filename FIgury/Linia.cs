using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
    public class Linia
    {
        private Punkt p1, p2;
        public Linia()
        {
            p1 = new Punkt();
            p2 = new Punkt();
        }
        public Linia(Punkt p1, Punkt p2)
        {
            this.p1 = new Punkt(p1);
            this.p2 = new Punkt(p2);
        }
        public Linia(Linia linia)
        {
            p1 = new Punkt(linia.p1);
            p2 = new Punkt(linia.p2);
        }
        public void przesun(int dx, int dy)
        {
            p1.przesun(dx, dy);
            p2.przesun(dx, dy);
        }
        public override string ToString()
        {
            return p1.ToString() + "<--->" + p2.ToString();
        }
        public Punkt getP1()
        {
            return p1;
        }
        public Punkt getP2()
        {
            return p2;
        }
    }
}
