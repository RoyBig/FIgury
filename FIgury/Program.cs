using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
    public class Program
    {
        private static Punkt wczytajPunkt()
        {
            Console.WriteLine("Podaj x: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj y: ");
            int y = int.Parse(Console.ReadLine());
            return new Punkt(x, y);
        }
        private static bool czy_Wspolliniowe(Punkt p1, Punkt p2, Punkt p3)
        {
            int a, b;
            a=(p2.getX() - p1.getX()) * (p3.getY() - p1.getY());
            b=(p2.getY() - p1.getY()) * (p3.getX() - p1.getX());
            if (a == b) return true;
            else return false;
        }

        private static bool czyCzworokat(Punkt p1, Punkt p2, Punkt p3, Punkt p4)
        {
            if (czy_Wspolliniowe(p1, p2, p3)) return false;
            else if (czy_Wspolliniowe(p2, p3, p4)) return false;
            else if (czy_Wspolliniowe(p3, p4, p1)) return false;
            else if (czy_Wspolliniowe(p4, p1, p2)) return false;
            else return true;
        }

        private static bool czyTrojkat(Punkt p1, Punkt p2, Punkt p3)
        {
            if (czy_Wspolliniowe(p1, p2, p3)) return false;
            else return true;
        }
        public static void Main()
        {
            Punkt punkt1 = new Punkt(0, 0), punkt2 = new Punkt(1, 1);
            Linia linia1 = new Linia(punkt1, punkt2), linia2 = new Linia(punkt1, punkt2);
            linia1.przesun(5, 5);
            Console.WriteLine(linia1.ToString());
            Console.WriteLine(linia2.ToString());          
            Obraz lista = new Obraz();
            do
            {
                Punkt p1, p2, p3;
                Linia l1, l2, l3;
                Console.WriteLine("||||||||||||||\nMENU:\n||||||||||||||\n");
                Console.WriteLine("1.Dodaj trojkąt\n2.Dodaj czworokąt\n3.Rysowanie obrazu\n4.Przesuwanie wszystkich figur\n5.Zakończenie działanie programu");
                Console.WriteLine("Opcja nr --> ");
                string opcja_nr = Console.ReadLine();
                switch (opcja_nr)
                {
                    case "1":
                        {
                            Console.WriteLine("Wczytaj 1-szy punkt");
                            p1 = wczytajPunkt();
                            Console.WriteLine("Wczytaj 2-gi punkt:");
                            p2 = wczytajPunkt();
                            Console.WriteLine("Wczytaj 3-ci punkt:");
                            p3 = wczytajPunkt();
                            if (!czyTrojkat(p1, p2, p3))
                            {
                                Console.WriteLine("Taki trójkąt nie istnieje!");
                                break;
                            }
                            l1 = new Linia(p1, p2);
                            l2 = new Linia(p1, p3);
                            l3 = new Linia(p2, p3);
                            Trojkat trojkat = new Trojkat(l1, l2, l3);
                            lista.dodajTrojkat(trojkat);
                            Console.WriteLine("Dodano nowy trójkąt!");
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Wczytaj 1-szy punkt");
                            p1 = wczytajPunkt();
                            Console.WriteLine("Wczytaj 2-gi punkt:");
                            p2 = wczytajPunkt();
                            Console.WriteLine("Wczytaj 3-ci punkt:");
                            p3 = wczytajPunkt();
                            Console.WriteLine("Wczytaj 4-ty punkt:");
                            Punkt p4 = wczytajPunkt();
                            if (!czyCzworokat(p1, p2, p3, p4))
                            {
                                Console.WriteLine("Taki czworokąt nie istnieje!");
                                break;
                            }
                            l1 = new Linia(p1, p2);
                            l2 = new Linia(p2, p3);
                            l3 = new Linia(p3, p4);
                            Linia l4 = new Linia(p4, p1);
                            Czworokat czworokat = new Czworokat(l1, l2, l3, l4);
                            lista.dodajCzworokat(czworokat);
                            Console.WriteLine("Dodano nowy czworokąt!");
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("Rysujemy obrazy:");
                            Console.WriteLine(lista.ToString());
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("Podaj przesunięcie x: ");
                            int x = int.Parse(Console.ReadLine());
                            Console.WriteLine("Podaj przesunięcie y: ");
                            int y = int.Parse(Console.ReadLine());
                            lista.przesun(x, y);
                            Console.WriteLine("Wszystkie figury zostały przesunięte!");
                            break;
                        }
                    case "5":
                        {
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("\nPodałeś błędną opcje!\n");
                            break;
                        }
                }
            }
            while(true);
        }
    }
}