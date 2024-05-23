using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
    public class Czworokat
    {
        private Linia l1, l2, l3, l4;
        public Czworokat()
        {
            l1 = new Linia();
            l2 = new Linia();
            l3 = new Linia();
            l4 = new Linia();
        }
        public Czworokat(Linia l1, Linia l2, Linia l3, Linia l4)
        {
            this.l1=new Linia(l1);
            this.l2=new Linia(l2);
            this.l3=new Linia(l3);
            this.l4=new Linia(l4);
                
        }
        public Czworokat(Czworokat czworokat)
        {
            l1=new Linia(czworokat.l1);
            l2=new Linia(czworokat.l2);
            l3=new Linia(czworokat.l3);
            l4=new Linia(czworokat.l4);
        }
        public void przesun(int dx, int dy)
        {
            l1.przesun(dx, dy);
            l2.przesun(dx, dy);
            l3.przesun(dx, dy);
            l4.przesun(dx, dy);
        }
        public override string ToString()
        {
            return l1.ToString() + ", " + l2.ToString() + ", " + l3.ToString() + ", " + l4.ToString();
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
        public Linia getL4()
        {
            return l4;
        }
    }
}
