using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
    public class Obraz
    {
        private List<Czworokat> czworokaty = new List<Czworokat>();
        private List<Trojkat> trojkaty = new List<Trojkat>();
        public Obraz()
        {
      
        }
        public void dodajTrojkat(Trojkat trojkat)
        {
            trojkaty.Add(trojkat);
        }
        public void dodajCzworokat(Czworokat czworokat)
        {
            czworokaty.Add(czworokat);
        }
        public void przesun(int dx, int dy)
        {
            trojkaty.ForEach(trojkat => trojkat.przesun(dx, dy));
            czworokaty.ForEach(czworokat => czworokat.przesun(dx, dy));
        }
        public override string ToString()
        {
            String builder = "";
            trojkaty.ForEach(trojkat => builder += (trojkat.ToString() + "\n"));
            czworokaty.ForEach(czworokat => builder += (czworokat.ToString() + "\n"));
            return builder;
        }
    }
}
