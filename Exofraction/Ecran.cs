using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exofraction
{
    public class Ecran
    {
        public static string Affiche(Fraction _f)
        {
            if (_f.getNumerateur() != 0)
            {
                string chaine = _f.getNumerateur() + "/" + _f.getDenominateur();
                Console.WriteLine(chaine);
                return chaine;
            }
            else
            {
                string chaine1 = "" + _f.getDenominateur();
                Console.WriteLine(chaine1);
                return chaine1;
            }
        }
        //public static bool egal(Fraction _f, Fraction _f1)
        //{
        //    bool test = true;

        //    if (_f.getNumerateur() / _f.getDenominateur() == _f1.getNumerateur() / _f1.getDenominateur())
        //    {
        //        test = true;
        //        Console.WriteLine("egal");
        //    }
        //    else
        //    {
        //        test = false;
        //        Console.WriteLine("Non pris en comte");

        //    }
        //    return test;
        //}
        public static bool Test(bool test)
        {
            if (test == true)
            {
                Console.WriteLine("vrai");
                return test;
            }
            else
            {
                Console.WriteLine("faux");
                return test;
            }


        }
    }
}
