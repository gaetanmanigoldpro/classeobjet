using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exofraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f = new Fraction(12, 7);
            Fraction f1 = new Fraction(9);
            Fraction f2 = new Fraction();

            //Console.WriteLine(f.AfficheFraction());
            //Console.WriteLine(f1.AfficheFraction());
            //Console.WriteLine(f2.AfficheFraction());
            Ecran.Affiche(f);
            Ecran.Affiche(f1);
            Ecran.Affiche(f2);
            //Console.WriteLine(f1.ToString());
            //Console.WriteLine(f2.ToString());

            Console.WriteLine("Appuyer sur une touche pour continuer...");
            Console.ReadKey();
            Console.WriteLine("__________________________________________");
            Fraction f4 = new Fraction(4, 7);
            f4 = f4.fracop();
            Ecran.Affiche(f4);
            Console.ReadKey();
            Console.WriteLine("__________________________________________");
            Fraction f5 = new Fraction(4, 7);
            f5 = f5.Inverse();
            Ecran.Affiche(f5);
            Console.ReadKey();
            Console.WriteLine("__________________________________________");
            Fraction f6 = new Fraction(5, 7);
            Fraction f7 = new Fraction(11, 7);
            bool rest =f6.Vrai(f7);
            Ecran.Test(rest);
            Console.ReadKey();
            Console.WriteLine("__________________________________________");
            Fraction f8 = new Fraction(11, 7);
            Fraction f9 = new Fraction(22, 14);
            //Ecran.egal(f8, f9);
            //Console.ReadKey();
            //Console.WriteLine("__________________________________________");
            //Fraction f10 = new Fraction(10, 5);
            //f10.Pgcd();
            //Console.ReadKey();


        }
    }
}
